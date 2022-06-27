using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ES_ExercicioPratico.Data;
using ES_ExercicioPratico.Models;

namespace ES_ExercicioPratico.Controllers
{
    public class KeysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KeysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Keys
        public async Task<IActionResult> Index()
        {
            return _context.Keys != null ?
                        View(await _context.Keys.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Keys'  is null.");
        }

        // GET: Keys/Details/
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Keys == null)
            {
                return NotFound();
            }

            var key = await _context.Keys
                .FirstOrDefaultAsync(m => m.Id == id);
            if (key == null)
            {
                return NotFound();
            }

            return View(key);
        }

        // GET: Keys/Create
        public IActionResult Create()
        {
            return View(new Key());
        }

        // POST: Keys/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Number1,Number2,Number3,Number4,Number5,Star1,Star2,CreatedAt,User, IsRandomKey")] Key key)
        {
            if (ModelState.IsValid && key.IsValid())
            {
                key.Id = Guid.NewGuid();
                _context.Add(key);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ModelState.AddModelError("", "A chave não é válida!");


            return View(key);
        }

        // GET: Keys/CreateRandomKey
        public IActionResult CreateRandomKey()
        {
            Key randomKey = new() { IsRandomKey = true };

            randomKey.Number1 = GetRandomNumber(1, 51);
            randomKey.Number2 = GetRandomNumber(1, 51, new int?[] { randomKey.Number1 });
            randomKey.Number3 = GetRandomNumber(1, 51, new int?[] { randomKey.Number1, randomKey.Number2 });
            randomKey.Number4 = GetRandomNumber(1, 51, new int?[] { randomKey.Number1, randomKey.Number2, randomKey.Number3 });
            randomKey.Number5 = GetRandomNumber(1, 51, new int?[] { randomKey.Number1, randomKey.Number2, randomKey.Number3, randomKey.Number4 });
            randomKey.Star1 = GetRandomNumber(1, 12);
            randomKey.Star2 = GetRandomNumber(1, 12, new int?[] { randomKey.Star1 });

            return View(nameof(Create), randomKey);
        }

        private int GetRandomNumber(int Min, int Max, int?[]? ExcludedNumbers = null)
        {
            Random randomGenerator = new Random();
            int currentNumber = randomGenerator.Next(Min, Max);

            if (ExcludedNumbers is not null)
            {
                while (ExcludedNumbers.Contains(currentNumber))
                {
                    currentNumber = randomGenerator.Next(Min, Max);
                }
            }
            return currentNumber;
        }


        // GET: Keys/Delete
        public async Task<IActionResult> Delete(Guid Id)
        {
            Key? key = await _context.Keys.Where(e => e.Id == Id).FirstOrDefaultAsync();

            if (key is not null)
            {
                _context.Keys.Remove(key);
                await _context.SaveChangesAsync();
            }

            return View(nameof(Index), await _context.Keys.ToListAsync());
        }

        // GET: Keys/Prizes
        public async Task<IActionResult> Prizes(DateTime? SelectedDate)
        {
            if (SelectedDate is null)
            {
                SelectedDate = DateTime.Now;
            }

            var selectedKey = new Key { Number1 = 1, Number2 = 2, Number3 = 3, Number4 = 4, Number5 = 5, Star1 = 1, Star2 = 2 };

            var prizeLists = await _context.Keys.Where(entity => entity.CreatedAt.Date == SelectedDate.Value.Date).ToListAsync();
            foreach (var item in prizeLists)
            {
                item.Prize = item.PrizePosition(selectedKey);
            }
            return View(new Prize() { SelectedDate = SelectedDate, keys = prizeLists });
        }
    }
}
