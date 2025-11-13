
---

## ⚙️ **Fase 2 — `src/fase-02-procedural/Program.cs`**

```csharp
using System;

namespace Fase02Procedural
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite um texto:");
            string texto = Console.ReadLine() ?? "";

            Console.WriteLine("Escolha o modo:");
            Console.WriteLine("1 - MAIÚSCULO");
            Console.WriteLine("2 - minúsculo");
            Console.WriteLine("3 - Título");
            Console.WriteLine("4 - Reverso (padrão)");
            int modo = int.Parse(Console.ReadLine() ?? "4");

            string resultado = FormatarTexto(texto, modo);
            Console.WriteLine($"\nTexto formatado: {resultado}");
        }

        static string FormatarTexto(string texto, int modo)
        {
            switch (modo)
            {
                case 1: return texto.ToUpper();
                case 2: return texto.ToLower();
                case 3: return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(texto);
                default:
                    char[] arr = texto.ToCharArray();
                    Array.Reverse(arr);
                    return new string(arr);
            }
        }
    }
}

