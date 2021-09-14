/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilsiateur

            // boucle sur le menu
            choix = 1;
            // L'entrée
            string Entry;
            bool check1, check2, check3;
            while (choix != 0)
            {
                // affiche le menu et saisi le choix
                check1 = false;
                check2 = false;
                check3 = false;
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                Entry = Console.ReadLine();
                check1 = int.TryParse(Entry, out int resultat);
                if (check1 == true)
                {
                    choix = int.Parse(Entry);
                    if(choix>=0 && choix<=2)
                    {
                        check2 = true;
                    }
                }
                while(check1 == false || check2 == false)
                {
                    Console.Clear();
                    Console.WriteLine("Erreur de saisie");
                    Console.WriteLine("Addition ....................... 1");
                    Console.WriteLine("Multiplication ................. 2");
                    Console.WriteLine("Quitter ........................ 0");
                    Console.Write("Choix :                          ");
                    Entry = Console.ReadLine();
                    check1 = int.TryParse(Entry, out int resultat2);
                    if (check1 == true)
                    {
                        choix = int.Parse(Entry);
                        if(choix>=0 && choix<=2)
                        {
                            check2 = true;
                        }
                    }
                }

                // traitement des choix
                if (choix != 0)
                {
                    //création des deux variables aléatoire
                    val1 = rand.Next(1, 10);
                    val2 = rand.Next(1, 10);
                    if (choix == 1)
                    {
                        // choix de l'addition
                        Console.Write(val1 + " + " + val2 + " = ");
                        // saisie de la réponse
                        Entry=Console.ReadLine();
                        check3 = int.TryParse(Entry, out int result3); //Check si la réponse est un nombre entier
                        while(check3 == false) // Si la réponse n'est pas un nombre entier
                        {
                            Console.Clear();;
                            Console.WriteLine("Erreur de saisie: veuillez entrer un nombre entier");
                            Console.Write(val1 + " + " + val2 + " = ");
                            // saisie de la réponse
                            Entry=Console.ReadLine();
                            check3 = int.TryParse(Entry, out int result4);
                        }
                        reponse = int.Parse(Entry);
                        // comparaison avec la bonne réponse
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                        }
                    }
                    else
                    {
                        // saisie de la réponse
                        Console.Write(val1 + " x " + val2 + " = ");
                        //Saisie de la réponse
                        Entry=Console.ReadLine();
                        check3 = int.TryParse(Entry, out int result3); //Check si la réponse est un nombre entier
                        while(check3 == false) // Si la réponse n'est pas un nombre entier
                        {
                            Console.Clear();;
                            Console.WriteLine("Erreur de saisie: veuillez entrer un nombre entier");
                            Console.Write(val1 + " x " + val2 + " = ");
                            // saisie de la réponse
                            Entry=Console.ReadLine();
                            check3 = int.TryParse(Entry, out int result4);
                        }
                        reponse = int.Parse(Entry);
                        // comparaison avec la bonne réponse
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                        }
                    }
                }
            }
        }
    }
}
