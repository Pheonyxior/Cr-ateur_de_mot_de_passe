using System;
using System.Collections.Generic;

namespace Créateur_de_mot_de_passe
{
    class Program
    {
        static void Main(string[] args)
        {
            // L'utilisateur choisit la longueur souhaitée du mot de passe 
            // Prend une entrée de l'utilisateur et vérifie si c'est un int. Si ce n'en est pas un, ou si le nombre donné n'est pas suffisant, répète cette commande.



            int nombre_de_caractères = 0;          // Déclare la variable
            int nombre_de_mdp = 0;                //
            int option_numéro = 0;                 // 
            int compteur = 0;                     //            


            do                                     // Fait passer un message et demande une entrée de l'utilisateur. Boucle tant qu'il ne s'agit pas de l'entrée désirée.
            {
                Console.WriteLine("Choisissez le nombre de caractères souhaités pour le mot de passe (4 minimums).");
            } while (!int.TryParse(Console.ReadLine(), out nombre_de_caractères) || nombre_de_caractères <= 3);
            Console.WriteLine("Le mot de passe fera " + nombre_de_caractères + " de longueur.");

            // Propose à l'utilisateur plusieurs options de générations de mdp
            // Prend une entrée de l'utilisateur pour choisir quelle option ils souhaitent et vérifie si c'est un int.
            // Si ce n'en est pas un, ou si le nombre donné n'est pas une option, répète cette commande.

            do
            {
                Console.WriteLine("Choisissez un critère de génération parmis les différentes options." +
                                 "\n 1 - Uniquement des caractères en minuscules" +
                                 "\n 2 - Des caractères minuscules et majuscules" +
                                 "\n 3 - Des caractères et des chiffres" +
                                 "\n 4 - Caractères, chiffres, et caractères spéciaux");
            } while (!int.TryParse(Console.ReadLine(), out option_numéro) || option_numéro < 1 || option_numéro > 4);

            // Affiche le choix de l'utilisateur et dix différents mots de passes, en colone

            Console.WriteLine("Votre choix : " + option_numéro);

            if (option_numéro == 1)                                               
            {
                while (nombre_de_mdp != 10)                             // Boucle tant que le nombres de mdp générés n'a pas atteint 10
                {
                    while (compteur != nombre_de_caractères)            // Boucle tant que le nombres de caractères générés n'a pas atteint 10
                    {
                        Random rand = new Random();
                        int ascii_index = rand.Next(97, 122);
                        char MinusculeT = Convert.ToChar(ascii_index);
                        compteur++;                       
                        Console.Write(MinusculeT);
                    }
                    nombre_de_mdp++;
                    compteur = 0;
                    Console.WriteLine("");
                }

            }
            if (option_numéro == 2)
            {
                while (nombre_de_mdp != 10)
                {
                    while (compteur != nombre_de_caractères)
                    {
                        Random rand = new Random();
                        string Database = "azertyuiopqsdfghjklmwxcvbnAZERTYUIOPQSDFGHJKLMWXCVBN";
                        int rdnm = rand.Next(0, Database.Length);
                        compteur++;
                        Console.Write(Database[rdnm]);
                    }
                    nombre_de_mdp++;
                    compteur = 0;
                    Console.WriteLine("");
                }
            }
            if (option_numéro == 3)
            {
                while (nombre_de_mdp != 10)
                {
                    while (compteur != nombre_de_caractères)
                    {
                        Random rand = new Random();
                        string Database = "azertyuiopqsdfghjklmwxcvbnAZERTYUIOPQSDFGHJKLMWXCVBN0123456789";
                        int rdnm = rand.Next(0, Database.Length);
                        compteur++;
                        Console.Write(Database[rdnm]);
                    }
                    nombre_de_mdp++;
                    compteur = 0;
                    Console.WriteLine("");
                }
            }
            if (option_numéro == 4)
            {
                while (nombre_de_mdp != 10)
                {
                    while (compteur != nombre_de_caractères)
                    {
                        Random rand = new Random();
                        int ascii_index = rand.Next(33, 122);
                        char MinusculeT = Convert.ToChar(ascii_index);
                        compteur++;
                        Console.Write(MinusculeT);
                    }
                    nombre_de_mdp++;
                    compteur = 0;
                    Console.WriteLine("");
                }
            }
        }
    }
}
       
