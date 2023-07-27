namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            

            IKrediManager tasitKrediManager = new TasitKrediManager();
           

            IKrediManager konutKrediManager = new KonutKrediManager();
            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(ihtiyacKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() { };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);


            //Interfaceler de o ınterface'i implamente eden sınıfın referans numarasını tutabilir

        }
    }
}