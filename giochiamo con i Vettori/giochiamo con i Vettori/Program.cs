using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giochiamo_con_i_Vettori
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vettore1 = new int[5]; //dichiarazione del tipo e istanziazione del vettore
            int[] vettore2; //dichiarazione del tipo di dato vettoriale
            vettore2 = new int[5]; //istanziazione del vettore (allocazione dello spazio in memoria heap)
            int[] vettore3 = new int[] {1,1,1,1,1}; //dichiarazione, istanziazione e inizializzazione
            var vettore4 = new int[5]; //equivale a int[] vettore4 = new int[5];
            int dimVettore = 5;
            var vettore5 = new int[dimVettore]; //equivale a int[] vettore4 = new int[5];
            var rnd = new Random();
            int esempio = 3;

            switch (esempio) {
                case 1:
                    Console.WriteLine("Inserisci il numero di estrazioni da effettuare");
                    do
                    {
                        dimVettore = int.Parse(Console.ReadLine());
                    } while (dimVettore < 1);
                    var vettore6 = new int[dimVettore]; //dichiara e istanzia un vettore di dimensione chiesta all'utente
                    for (int i = 0; i < dimVettore; i++)
                    {
                        vettore6[i] = rnd.Next(1, 51); //estrazione di un numero compreso tra 1 e 50
                    }

                    for (int i = 0; i < dimVettore; i++)
                    {
                        Console.Write(vettore6[i] + ","); 
                    }
                    break;
                case 2:
                    // riempimento casuale di un vettore di interi di dimensione chiesta all'utente
                    // con valori compresi tra un minimo e un massimo sempre chiesti all'utente
                    Console.WriteLine("\n\nInserisci la dimensione del vettore");
                    do
                    {
                        dimVettore = int.Parse(Console.ReadLine());
                    } while (dimVettore < 1);
                    var vett = new int[dimVettore]; //dichiara e istanzia un vettore di dimensione chiesta all'utente

                    int min, max;
                    Console.WriteLine("Inserisci il limite inferiore dei numeri casuali");
                    do
                    {
                        min = int.Parse(Console.ReadLine());
                    } while (min < 1);
                    Console.WriteLine("Inserisci il limite superiore dei numeri casuali");
                    do
                    {
                        max = int.Parse(Console.ReadLine());
                    } while (max <= min);

                    for (int i = 0; i < dimVettore; i++)
                    {
                        vett[i] = rnd.Next(min, max + 1); //estrazione di un numero compreso tra min e max
                        Console.Write(vett[i] + ",");
                    }
                    break;
                case 3:
                    // scrivere un algoritmo che chiede all'utente l'inserimento di una sequenza di numeri 
                    // crescenti all'interno di un vettore di interi di dimensione 10
                    var vettOrdinato = new int[10]; //dichiara e istanzia un vettore di dimensione chiesta all'utente
                    int numero;

                    Console.WriteLine("\nInserisci il primo numero nel vettore");
                    vettOrdinato[0]=int.Parse(Console.ReadLine()); //inserisco il primo numero nel vettore
                    bool finito = false;
                    int volte = 1;
                    do
                    {
                        Console.WriteLine("\nQuale numero vuoi inserire nel vettore?");
                        numero = int.Parse(Console.ReadLine()); //leggi il numero da tastiera
                        if (numero <= vettOrdinato[volte - 1]) //confronta il numero con quello letto in precedenza
                        {
                            //se non è maggiore avvisa l'utente
                            Console.WriteLine("Il numero inserito non è corretto! deve essere maggiore del precedente");
                        }
                        else
                        {
                            //è un numero "buono" per cui incrementa il numero delle volte che è stato inserito un numero corretto
                            volte++;
                            vettOrdinato[volte - 1] = numero;
                            if (volte == 10) {                                
                                finito = true;
                            }                            
                        }
                    } while (numero <= vettOrdinato[volte - 1] && finito==false);

                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(vettOrdinato[i] + ",");
                    }
                    break;

                case 4:
                    //chiede l'inserimento delle altezze di 10 studenti, quindi calcola la media delle altezze
                    //e se ci sono studenti della stessa altezza (compresa tra 120 e 210 cm)
                    var altezzaStudenti = new int[10];

                    for(int i = 0; i < 10; i++)
                    {
                        int altezza;
                        do
                        {
                            //leggo altezza e controllo che sia compresa nell'intervallo consentito
                            Console.Write($"\nInserisci l'altezza del {i+1}° studente:");
                            altezza = int.Parse(Console.ReadLine());
                        } while (altezza < 120 || altezza > 210);
                        altezzaStudenti[i] = altezza;
                    }

                    int sommaAltezze = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        sommaAltezze=sommaAltezze+altezzaStudenti[i];
                    }
                    int mediaAltezze = sommaAltezze / 10;
                    Console.WriteLine($"La media delle altezze degli studenti è {mediaAltezze}");

                    break;
                }

            Console.ReadKey();

        }
    }
}
