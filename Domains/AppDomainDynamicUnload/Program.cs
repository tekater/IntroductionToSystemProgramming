using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainDynamicUnload
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//1) Создаём домен приложения:
			AppDomain domain = AppDomain.CreateDomain("Demo");

			//2) Загружаем DLL в домен:
			Assembly asm = domain.Load(AssemblyName.GetAssemblyName("SampleLibrary.dll"));

			//3) Получаем модуль из которого будем вызывать функцию:
			Module module = asm.GetModule("SampleLibrary.dll");

			//4) Получаем класс, который содержит нужный метод:
			Type type = module.GetType("SampleLibrary.SampleClass");

			//5) Вынимаем метод из класса:
			MethodInfo methodInfo = type.GetMethod("Print");

			//6) Вызываем метод:
			methodInfo.Invoke(null, null);

            Console.WriteLine("Press any key to continue...\n");
            Console.ReadLine();
        }
	}
}
