using System;

namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker dw = new DocumentWorker();
            dw.OpenDocument();
            dw.EditDocument();
        }
    }
     class DocumentWorker
     {

         public void OpenDocument(){
           Console.WriteLine("Документ открыт");
         }

         public void EditDocument(){
            Console.WriteLine("Редоктирование документа доступно в версии Про");
         }

         public void SaveDocument(){
             Console.WriteLine("Сохранение документа доступно в версии Про");
         }
     } 

     class ProDocumentWorker:DocumentWorker
     {

     }
}
