using System;

namespace HomeWork10
{
    class Program
    {
        
        static void Main(string[] args)
        { 
            //Задание 2.
            // Console.ForegroundColor = ConsoleColor.Red;
            // Console.WriteLine("---------------------------------------");
            // Console.WriteLine("Your key for Pro version is: 12345");
            // Console.WriteLine("Your key for Export version is: 123456");
            // Console.WriteLine("Basic version is: Free without any key, you have to press Enter");
            // Console.WriteLine("Choose your versions:");
            // Console.WriteLine("---------------------------------------");
            // Console.ForegroundColor = ConsoleColor.White;

            // string key = Console.ReadLine();  
            // DocumentWorker document = new DocumentWorker();
                
             
            // if(key == "12345"){
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("----------Pro version-----------");
            //    document =  new ProDocumentWorker(); 
            //    document.EditDocument();
            //    document.SaveDocument();
            //    Console.ForegroundColor = ConsoleColor.White;
               
            // }
            // else if(key == "123456"){
            //     Console.ForegroundColor = ConsoleColor.Yellow;
            //      Console.WriteLine("----------Experess version-----------");
            //      document = new ExpertDocumentWorker();
            //      document.SaveDocument();
            //      Console.ForegroundColor = ConsoleColor.White;
            // }
            // else{
            //     Console.ForegroundColor = ConsoleColor.Blue;
            //     Console.WriteLine("----------Basic version-----------");
            //     document.OpenDocument();
            //     document.EditDocument();
            //     document.SaveDocument();
            //     Console.ForegroundColor = ConsoleColor.White;
            // }
            
            //Задание 3
            // Player pl = new Player();
            // pl.Play();
            // pl.Pause();
            // pl.Stop();
            // pl.Record();
            
        }
    }

    //Задание 2
    //  class DocumentWorker
    //  {
        
    //      public virtual void OpenDocument(){
           
    //        Console.WriteLine("Документ открыт");
    //      }

    //      public virtual void EditDocument(){
             
    //         Console.WriteLine("Редоктирование документа доступно в версии Про");
    //      }

    //      public virtual void SaveDocument(){
            
    //          Console.WriteLine("Сохранение документа доступно в версии Про");
             
    //          Console.WriteLine("------------------------------------------------");
    //      }
    //  } 
    
    //  class ProDocumentWorker:DocumentWorker
    //  {
         
    //     public override void EditDocument()
    //     {
            
    //         Console.WriteLine("Документ отредоктирван");
    //     }

    //     public override void SaveDocument(){
    //         Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
    //          Console.WriteLine("------------------------------------------------");
    //     }
    //  }

    //  class ExpertDocumentWorker:ProDocumentWorker
    //  {
    //         public override void SaveDocument(){
    //             Console.WriteLine("Документ сохранен в новом формате");
    //              Console.WriteLine("------------------------------------------------");
    //         }
    //  }



    // Задание 3.

    // interface Iplayble
    // {
    //    void Play();

    //    void Pause();

    //    void Stop();

       
    // }
    // interface IRecodable
    // {
    //    void Record();

    //    void Pause();

    //    void Stop();

       
    // }

    // class Player : Iplayble,IRecodable
    // {
    //     public void Pause()
    //     {
    //         Console.WriteLine("Pause");
    //     }

    //     public void Play()
    //     {
    //         Console.WriteLine("Play");
    //     }

    //     public void Record()
    //     {
    //         Console.WriteLine("Record");
    //     }

    //     public void Stop()
    //     {
    //         Console.WriteLine("Stop");
    //     }
    // }

    

}
