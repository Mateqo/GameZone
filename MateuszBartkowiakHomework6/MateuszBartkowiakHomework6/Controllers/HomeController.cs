using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MateuszBartkowiakHomework6.Models;

namespace MateuszBartkowiakHomework6.Controllers
{
    public class HomeController : Controller
    {
        // Deklaracja listy gier
        List<GameViewModel> games;
        // Deklaracja listy gier po filtrowaniu
        List<GameViewModel> checkGames;
        


        public HomeController()
        {
            // Tworzymy Listę 
            games = new List<GameViewModel>();
            
            
            // Dodajemy do listy gry
            games.Add(new GameViewModel("Witcher 3", "RPG", 2015, 120, "~/Content/Images/witcherPc.jpg", "~/Content/Images/witcherGameplay1.jpg", "~/Content/Images/witcherGameplay2.jpg", "Wiedźmin 3: Dziki Gon – fabularna gra akcji stworzona i wydana przez polskie studio CD Projekt RED 19 maja 2015 na platformy Microsoft Windows, PlayStation 4 i Xbox One. Gra jest kontynuacją wydanego w 2007 roku Wiedźmina oraz Wiedźmina 2: Zabójców królów, który miał swoją premierę w 2011 roku.", "PC"));
            games.Add(new GameViewModel("Witcher 3", "RPG", 2015, 220, "~/Content/Images/witcherXbox.jpg", "~/Content/Images/witcherGameplay1.jpg", "~/Content/Images/witcherGameplay2.jpg", "Wiedźmin 3: Dziki Gon – fabularna gra akcji stworzona i wydana przez polskie studio CD Projekt RED 19 maja 2015 na platformy Microsoft Windows, PlayStation 4 i Xbox One. Gra jest kontynuacją wydanego w 2007 roku Wiedźmina oraz Wiedźmina 2: Zabójców królów, który miał swoją premierę w 2011 roku.", "XBOX ONE"));
            games.Add(new GameViewModel("Witcher 3", "RPG", 2015, 220, "~/Content/Images/witcherPs4.jfif", "~/Content/Images/witcherGameplay1.jpg", "~/Content/Images/witcherGameplay2.jpg", "Wiedźmin 3: Dziki Gon – fabularna gra akcji stworzona i wydana przez polskie studio CD Projekt RED 19 maja 2015 na platformy Microsoft Windows, PlayStation 4 i Xbox One. Gra jest kontynuacją wydanego w 2007 roku Wiedźmina oraz Wiedźmina 2: Zabójców królów, który miał swoją premierę w 2011 roku.", "PS4"));
            games.Add(new GameViewModel("Battlefield V", "Shooter", 2018, 170, "~/Content/Images/battlefieldPc.webp", "~/Content/Images/battlefieldGameplay1.jpg", "~/Content/Images/battlefieldGameplay2.jpg", "Battlefield V jest kolejną częścią bestsellerowej serii strzelanek tworzonych przez należące do firmy Electronic Arts studio DICE. Produkcja została osadzona w realiach II wojny, ale zamiast powrotu do korzeni cyklu, autorzy postawili na własną, dość swobodną wizję tego konfliktu.","PC"));
            games.Add(new GameViewModel("Battlefield V", "Shooter", 2018, 210, "~/Content/Images/battlefieldXbox.webp", "~/Content/Images/battlefieldGameplay1.jpg", "~/Content/Images/battlefieldGameplay2.jpg", "Battlefield V jest kolejną częścią bestsellerowej serii strzelanek tworzonych przez należące do firmy Electronic Arts studio DICE. Produkcja została osadzona w realiach II wojny, ale zamiast powrotu do korzeni cyklu, autorzy postawili na własną, dość swobodną wizję tego konfliktu.", "XBOX ONE"));
            games.Add(new GameViewModel("Battlefield V", "Shooter", 2018, 210, "~/Content/Images/battlefieldPs4.webp", "~/Content/Images/battlefieldGameplay1.jpg", "~/Content/Images/battlefieldGameplay2.jpg", "Battlefield V jest kolejną częścią bestsellerowej serii strzelanek tworzonych przez należące do firmy Electronic Arts studio DICE. Produkcja została osadzona w realiach II wojny, ale zamiast powrotu do korzeni cyklu, autorzy postawili na własną, dość swobodną wizję tego konfliktu.", "PS4"));
            games.Add(new GameViewModel("Assassin's Creed Odyssey", "Adventure", 2018, 160, "~/Content/Images/assassinPc.jpg", "~/Content/Images/assassinGameplay1.webp", "~/Content/Images/assassinGameplay2.jpg", "Gracz wciela się w jednego z dwóch dostępnych bohaterów – Aleksiosa lub Kasandrę. Bohater jest misthiosem – greckim najemnikiem. Przed laty jego ojciec zrzucił go z góry Tajget niedaleko Sparty, za co bohater ma do niego żal. Cudem uniknąwszy śmierci, uciekł na Kefalonię, gdzie spotkał Markosa.", "PC"));
            games.Add(new GameViewModel("Assassin's Creed Odyssey", "Adventure", 2018, 200, "~/Content/Images/assassinXbox.jpg", "~/Content/Images/assassinGameplay1.webp", "~/Content/Images/assassinGameplay2.jpg", "Gracz wciela się w jednego z dwóch dostępnych bohaterów – Aleksiosa lub Kasandrę. Bohater jest misthiosem – greckim najemnikiem. Przed laty jego ojciec zrzucił go z góry Tajget niedaleko Sparty, za co bohater ma do niego żal. Cudem uniknąwszy śmierci, uciekł na Kefalonię, gdzie spotkał Markosa.", "XBOX ONE"));
            games.Add(new GameViewModel("Assassin's Creed Odyssey", "Adventure", 2018, 200, "~/Content/Images/assassinPs4.jpg", "~/Content/Images/assassinGameplay1.webp", "~/Content/Images/assassinGameplay2.jpg", "Gracz wciela się w jednego z dwóch dostępnych bohaterów – Aleksiosa lub Kasandrę. Bohater jest misthiosem – greckim najemnikiem. Przed laty jego ojciec zrzucił go z góry Tajget niedaleko Sparty, za co bohater ma do niego żal. Cudem uniknąwszy śmierci, uciekł na Kefalonię, gdzie spotkał Markosa.", "PS4"));
            games.Add(new GameViewModel("The Elder Scrolls V Skyrim", "RPG", 2011, 60, "~/Content/Images/skyrimPc.jpg", "~/Content/Images/skyrimGameplay1.jpg", "~/Content/Images/skyrimGameplay2.jpg", "Fabuła Skyrim rozgrywa się dwieście lat po wydarzeniach przedstawionych w grze Oblivion, nie jest jednak jej bezpośrednią kontynuacją, a nową historią osadzoną w uniwersum The Elder Scrolls. Po śmierci cesarza Martina Septima i zakończeniu kryzysu Otchłani rozpoczęła się czwarta era.", "PC"));
            games.Add(new GameViewModel("The Elder Scrolls V Skyrim", "RPG", 2011, 100, "~/Content/Images/skyrimXbox.jpg", "~/Content/Images/skyrimGameplay1.jpg", "~/Content/Images/skyrimGameplay2.jpg", "Fabuła Skyrim rozgrywa się dwieście lat po wydarzeniach przedstawionych w grze Oblivion, nie jest jednak jej bezpośrednią kontynuacją, a nową historią osadzoną w uniwersum The Elder Scrolls. Po śmierci cesarza Martina Septima i zakończeniu kryzysu Otchłani rozpoczęła się czwarta era.", "XBOX ONE"));
            games.Add(new GameViewModel("The Elder Scrolls V Skyrim", "RPG", 2011, 100, "~/Content/Images/skyrimPs4.jpg", "~/Content/Images/skyrimGameplay1.jpg", "~/Content/Images/skyrimGameplay2.jpg", "Fabuła Skyrim rozgrywa się dwieście lat po wydarzeniach przedstawionych w grze Oblivion, nie jest jednak jej bezpośrednią kontynuacją, a nową historią osadzoną w uniwersum The Elder Scrolls. Po śmierci cesarza Martina Septima i zakończeniu kryzysu Otchłani rozpoczęła się czwarta era.", "PS4"));
            games.Add(new GameViewModel("Shadow of the Tomb Raider", "Adventure", 2018, 150, "~/Content/Images/tombRaiderPc.webp", "~/Content/Images/tombRaiderGameplay1.png", "~/Content/Images/tombRaiderGameplay2.jpg", "Akcja gry osadzona została po wydarzeniach z Rise of the Tomb Raider. Główna bohaterka, archeolog Lara Croft, wyrusza na poszukiwanie artefaktu Majów powiązanego z jej zmarłym ojcem. Poszukuje go również Trójca, paramilitarna organizacja badająca zjawiska nadprzyrodzone i główny wróg Lary.", "PC"));
            games.Add(new GameViewModel("Shadow of the Tomb Raider", "Adventure", 2018, 190, "~/Content/Images/tombRaiderXbox.jpg", "~/Content/Images/tombRaiderGameplay1.png", "~/Content/Images/tombRaiderGameplay2.jpg", "Akcja gry osadzona została po wydarzeniach z Rise of the Tomb Raider. Główna bohaterka, archeolog Lara Croft, wyrusza na poszukiwanie artefaktu Majów powiązanego z jej zmarłym ojcem. Poszukuje go również Trójca, paramilitarna organizacja badająca zjawiska nadprzyrodzone i główny wróg Lary.", "XBOX ONE"));
            games.Add(new GameViewModel("Shadow of the Tomb Raider", "Adventure", 2018, 190, "~/Content/Images/tombRaiderPs4.webp", "~/Content/Images/tombRaiderGameplay1.png", "~/Content/Images/tombRaiderGameplay2.jpg", "Akcja gry osadzona została po wydarzeniach z Rise of the Tomb Raider. Główna bohaterka, archeolog Lara Croft, wyrusza na poszukiwanie artefaktu Majów powiązanego z jej zmarłym ojcem. Poszukuje go również Trójca, paramilitarna organizacja badająca zjawiska nadprzyrodzone i główny wróg Lary.", "PS4"));
            games.Add(new GameViewModel("Call of Duty Modern Warfare", "Shooter", 2019, 190, "~/Content/Images/callOfDutyPc.jpg", "~/Content/Images/callOfDutyGameplay1.jpg", "~/Content/Images/callOfDutyGameplay2.jpg", "Główna fabuła gry Call of Duty: Modern Warfare toczy się w 2019 roku. Niektóre misje są jednak retrospekcją i rozgrywają się kilkanaście lat wcześniej. Gracze wcielają się w postacie trzech głównych bohaterów – operatora CIA, brytyjskiego policjanta oraz przywódczyni partyzantów.","PC"));
            games.Add(new GameViewModel("Call of Duty Modern Warfare", "Shooter", 2019, 240, "~/Content/Images/callOfDutyXbox.webp", "~/Content/Images/callOfDutyGameplay1.jpg", "~/Content/Images/callOfDutyGameplay2.jpg", "Główna fabuła gry Call of Duty: Modern Warfare toczy się w 2019 roku. Niektóre misje są jednak retrospekcją i rozgrywają się kilkanaście lat wcześniej. Gracze wcielają się w postacie trzech głównych bohaterów – operatora CIA, brytyjskiego policjanta oraz przywódczyni partyzantów.", "XBOX ONE"));
            games.Add(new GameViewModel("Call of Duty Modern Warfare", "Shooter", 2019, 240, "~/Content/Images/callOfDutyPs4.webp", "~/Content/Images/callOfDutyGameplay1.jpg", "~/Content/Images/callOfDutyGameplay2.jpg", "Główna fabuła gry Call of Duty: Modern Warfare toczy się w 2019 roku. Niektóre misje są jednak retrospekcją i rozgrywają się kilkanaście lat wcześniej. Gracze wcielają się w postacie trzech głównych bohaterów – operatora CIA, brytyjskiego policjanta oraz przywódczyni partyzantów.", "PS4"));
        }

        /// <summary>
        /// Strona głowna
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Lista gier PC
        /// </summary>
        /// <returns></returns>
        public IActionResult PC()
        {
            return View(games);
        }

        /// <summary>
        /// Lista gier XBOX
        /// </summary>
        /// <returns></returns>
        public IActionResult XBOX()
        {
            return View(games);
        }

        /// <summary>
        /// Lista gier PS4
        /// </summary>
        /// <returns></returns>
        public IActionResult PS4()
        {
            return View(games);
        }

        /// <summary>
        /// Pusty koszyk gdy nic nie dodamy
        /// </summary>
        /// <returns></returns>
        public IActionResult EmptyTrolley()
        {
            return View();
        }

        /// <summary>
        /// Koszyk z produktem jaki wybierzemy
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public IActionResult Trolley(string platform, string name)
        {
            // Tworzymy listę zakupionych produktów
            List<GameViewModel> trolley = new List<GameViewModel>();

            // wysukujemy z listy gier wybraną przez nas
            foreach (var game in games)
                if (game.Platform== platform && game.Name == name)
                {
                    // Dodajemy wybraną grę do naszej listy
                    trolley.Add(game);
                }

            return View(trolley);
        }

        /// <summary>
        /// Filtracja po typie gry
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public IActionResult GetGameByType(string platform,string type)
        {    
            // Tworzymy liste
            checkGames = new List<GameViewModel>();
            // Czyścimy filtr
            checkGames.Clear();
           
            // Szukamy gier które odpowiadają naszemu filtrowi
            foreach (var game in games)
                if (game.Type == type && game.Platform == platform)
                {
                    // Dodajemy do listy
                    checkGames.Add(game);
                }

            return View(checkGames);
        }

        /// <summary>
        /// Formularz do zakupu (wypełnianie)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ContactForm()
        {
            return View();
        }

        /// <summary>
        /// Formularz do zakupu wysłany/odpowiedź
        /// </summary>
        /// <param name="formViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ContactForm(ContactFormViewModel formViewModel)
        {
            string fullName = formViewModel.FirstName + " " + formViewModel.LastName;
            // przechowanie tymczasowo stringa
            ViewBag.UserName = fullName;

            string email = formViewModel.Email;
            ViewBag.Email = email;

            return View("ContactFormSuccess");
        }

        /// <summary>
        /// Formularz do Newslettera (wypełnienie)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult NewsLetter()
        {
            return View();
        }

        /// <summary>
        /// Formularz do NewsLetter wysłany/odpowiedź
        /// </summary>
        /// <param name="formViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult NewsLetter(NewsLetterViewModel formViewModel)
        {
            string name = formViewModel.Username;
            ViewBag.Username = name;

            string email = formViewModel.Email;
            ViewBag.Email = email;

            return View("NewsLetterSuccess");
        }

        /// <summary>
        /// Formularz z opinią (wypełnienie)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Opinion()
        {
            return View();
        }

        /// <summary>
        /// Formularz z opinią wysłany/odpowiedź
        /// </summary>
        /// <param name="formViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Opinion(OpinionViewModel formViewModel)
        {
            string name = formViewModel.Username;
            TempData["login"] = name;

            return View("OpinionSuccess");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
