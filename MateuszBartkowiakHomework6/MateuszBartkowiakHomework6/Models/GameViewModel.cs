using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MateuszBartkowiakHomework6.Models
{
    public class GameViewModel
    {
        /// <summary>
        /// Nazwa gry
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Typ gry
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Rok produkcji
        /// </summary>
        public int YearOfProduction  { get; set; }
        /// <summary>
        /// Cena
        /// </summary>
        public decimal Price  { get; set; }
        /// <summary>
        /// Zdjęcie
        /// </summary>
        public string Photo  { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Description  { get; set; }
        /// <summary>
        /// Platforma
        /// </summary>
        public string Platform  { get; set; }
        /// <summary>
        /// Zdjęcie z gry
        /// </summary>
        public string Gameplay1  { get; set; }
        /// <summary>
        /// Zdjęcie z gry
        /// </summary>
        public string Gameplay2 { get; set; }



        /// <summary>
        /// Kontruktor który przypisuje 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="yearOfProduction"></param>
        /// <param name="price"></param>
        /// <param name="photo"></param>
        /// <param name="gamepley1"></param>
        /// <param name="gameplay2"></param>
        /// <param name="description"></param>
        /// <param name="platform"></param>
        public GameViewModel(string name,string type,int yearOfProduction,decimal price,string photo,string gamepley1,string gameplay2,string description,string platform)
        {
            Name = name;
            Type = type;
            YearOfProduction = yearOfProduction;
            Price = price;
            Photo = photo;
            Description = description;
            Platform = platform;
            Gameplay1 = gamepley1;
            Gameplay2 = gameplay2;
        }

    }
}
