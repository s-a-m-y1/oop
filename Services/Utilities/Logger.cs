using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services.Utilities
{
   
        public sealed class Logger
        {
            // ميثود ثابتة بنناديها باسم الكلاس
            public static void Log(string message)
            {
                // بتطبع الوقت الحالي مع الرسالة عشان نعرف العملية حصلت إمتى
                Console.WriteLine($"[BANK-LOG] {DateTime.Now}: {message}");
            }
        }
    }

