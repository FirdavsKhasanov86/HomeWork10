using System;

namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker dw = new DocumentWorker();
            ProDocumentWorker pdw = new ProDocumentWorker(); 
            dw.OpenDocument();
            dw.EditDocument();
            dw.SaveDocument();
            pdw.EditDocument();
            pdw.SaveDocument();
            
            
        }
    }
     class DocumentWorker
     {

         public virtual void OpenDocument(){
           
           Console.WriteLine("Документ открыт");
         }

         public virtual void EditDocument(){
             
            Console.WriteLine("Редоктирование документа доступно в версии Про");
         }

         public virtual void SaveDocument(){
            
             Console.WriteLine("Сохранение документа доступно в версии Про");
             
             Console.WriteLine("------------------------------------------------");
         }
     } 

     class ProDocumentWorker:DocumentWorker
     {
         
        public override void EditDocument()
        {
            
            Console.WriteLine("Документ отредоктирван");
        }

        public override void SaveDocument(){
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
           
        }
     }
}
