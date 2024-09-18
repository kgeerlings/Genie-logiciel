// See https://aka.ms/new-console-template for more information

public class ATM
{
    public double Solde { get; set; }
    public double Somme { get; set; }

    enum Etat { attente, accueil, retrait, versement }

    public ATM(double solde)
    {
        Solde = solde;
        Somme = 0;
    }

    public void InsererCarte()
    {
        Console.WriteLine("Inserez votre carte");
        Console.Write("Press <Enter> to enter card... ");
        Console.WriteLine();
        if (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            Console.WriteLine("Que souhaitez vous effectuer comme action? Indiquez son numéro.");
            Console.Write("1. Verser une somme" + '\n' + "2. Retirer une somme" + '\n' + "3. Afficher solde" + '\n' + "4. Quitter");
            Console.WriteLine();
            int action = Int32.Parse(Console.ReadLine()!);
            switch (action)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Quelle somme souhaitez-vous verser?");
                    double somme = Int64.Parse(Console.ReadLine()!);
                    Verser(somme);
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Quelle somme souhaitez-vous retirer?");
                    double somme2 = Int64.Parse(Console.ReadLine()!);
                    Retirer(somme2);
                    break;
                case 3:
                    AfficherSolde();
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Vous allez quitter l'application.");
                    break;

                default:
                    break;

            }
        }
    }

    void Verser(double somme)
    {
        Solde += somme;
        Console.WriteLine();
        Console.WriteLine("Votre solde a été mis à jour.");
        Console.WriteLine("Votre solde est actuellement de " + Solde + " euros.");
    }

    void Retirer(double somme)
    {
        if (Solde >= somme)
        {
            Solde -= somme;
            Console.WriteLine();
            Console.WriteLine("Votre solde a été mis à jour.");
            Console.WriteLine("Votre solde est actuellement de " + Solde + " euros.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("La somme que vous souhaitez retirer est supérieur à votre solde.");
        }
    }

    void AfficherSolde()
    {
        Console.WriteLine();
        Console.WriteLine("Votre solde est de " + Solde + " euros.");
    }
}