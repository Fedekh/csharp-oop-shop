using System;

namespace csharp_oop_shop
{
    class Prodotto
    {
        private string code;
        public string Name { get; set; }
        public string Description { get; set; }

        private decimal price;
        public string Iva { get; set; }

        public Prodotto(string name, string description, decimal price, string iva)
        {
            int cod = new Random().Next(1000, 9999);
            this.code = cod.ToString();
            this.Name = name;
            this.Description = description;
            this.price = price;
            this.Iva = iva;
        }

        // ottenere il prezzo base
        public decimal GetPrezzoBase()
        {
            return price;
        }
        public string GetCodePad()
        {
            
            return code.PadLeft(8,'0');
        }

        // ottenere il prezzo comprensivo di IVA
        public decimal GetPrezzoConIva(string iva)
        {
            if (decimal.TryParse(iva, out decimal ivaValue))
            {
                return price + (price * (ivaValue / 100));
            }
            else
            {
                throw new Exception("Iva non valida");
            }
        }

        // Metodo per ottenere il nome esteso (codice + nome)
        public string GetNomeEsteso()
        {
            return $"{code} {Name}";
        }

        public override string ToString() //serve per sovrascrivere il metodo Console.WriteLine()
        {
            return $"Codice: {GetCodePad()}, Nome: {Name}, Descrizione: {Description}, Prezzo: {price}, IVA: {Iva}";
        }

      
    }
}
