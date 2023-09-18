using csharp_oop_shop;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharpoopshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ciao");

            Prodotto gelato = new Prodotto("Gelato al limone", "Buono gelato al limone", 25.7m, "22");
            Console.WriteLine(gelato);
            Console.WriteLine(gelato.GetCodePad());

            Console.WriteLine("Inserisci iva");

            gelato.GetPrezzoConIva(Console.ReadLine());
            Prodotto[] negozio = new Prodotto[5];

            negozio[0] = new Prodotto("Gelato al cioccolato", "Delizioso gelato al cioccolato", 3.5m, "22");
            negozio[1] = new Prodotto("Maglietta", "Maglietta di cotone", 15.0m, "18");
            negozio[2] = new Prodotto("Smartphone", "Ultimo modello di smartphone", 699.99m, "22");
            negozio[3] = new Prodotto("Libro", "Bestseller del momento", 12.99m, "4");
            negozio[4] = new Prodotto("Scarpe da corsa", "Scarpe leggere per correre", 49.99m, "22");

            foreach (var i in negozio)
            {
                Console.WriteLine(i);
            }

        }
    }
}

//creare la classe Prodotto che gestisce i prodotti di uno shop.
/*Un prodotto è caratterizzato da:
codice(numero intero)
nome
descrizione
prezzo
iva
Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
Il codice prodotto sia accessibile solo in lettura
Gli altri attributi siano accessibili sia in lettura che in scrittura
Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interagirci per testare tutti i metodi che avete previsto.
BONUS:
create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 12344556 resta come è)
Usando un array fisso di 5 prodotti, dichiarate un elenco dei prodotti di un negozio e inseriteci al suo interno qualche prodotto che vi aspettate di trovare nel negozio. Stampate poi l’elenco dei vostri prodotti che avete previsto nel negozio.
Buon lavoro!
*/