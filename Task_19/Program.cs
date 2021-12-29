using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Сomputer> computer = new List<Сomputer>()
            {
                new Сomputer() {Сode=1, Name="Celeron 1.2+1Tb", TypeProcessor="Celeron", CPU=1.2, RAM=1024, HardDisk=1024, VideoCardMemory=1024, Summa=50000, Quantity=30},
                new Сomputer() {Сode=2, Name="AMD 3.2+2Tb", TypeProcessor="AMD", CPU=3.2, RAM=2048, HardDisk=1024, VideoCardMemory=1024, Summa=120000, Quantity=2},
                new Сomputer() {Сode=3, Name="Celeron 2.2+2Tb", TypeProcessor="Celeron", CPU=2.2, RAM=1024, HardDisk=2048, VideoCardMemory=2048, Summa=75000, Quantity=5},
                new Сomputer() {Сode=4, Name="AMD 1.2+1Tb", TypeProcessor="AMD", CPU=1.2, RAM=2048, HardDisk=1024, VideoCardMemory=1024, Summa=60000, Quantity=0},
                new Сomputer() {Сode=5, Name="Intel 5.2+1.5Tb", TypeProcessor="Intel", CPU=5.2, RAM=2048, HardDisk=1024, VideoCardMemory=1024, Summa=145000, Quantity=40},
                new Сomputer() {Сode=6, Name="Celeron 4.8+1Tb", TypeProcessor="Celeron", CPU=4.8, RAM=2048, HardDisk=2048, VideoCardMemory=2048, Summa=170000, Quantity=1},
                new Сomputer() {Сode=7, Name="Celeron 1.5+2Tb", TypeProcessor="Celeron", CPU=1.5, RAM=2048, HardDisk=1024, VideoCardMemory=2048, Summa=90000, Quantity=27}
            };

            Console.WriteLine("Поиск по имени процессора.Введите имя процессора: ");
            string typeProcessor = Console.ReadLine();
            List<Сomputer> computers1 = computer.Where(x => x.TypeProcessor == typeProcessor).ToList();
            Print(computers1);

            Console.WriteLine("Поиск по объему ОЗУ. Введите ОЗУ: ");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Сomputer> computer2 = computer.Where(x => x.RAM >= ram).ToList();
            Print(computer2);

            Console.WriteLine();
            Console.WriteLine("Список, отсортированный по увеличению стоимости");
            List<Сomputer> computer3 = computer.OrderBy(x => x.Summa).ToList();
            Print(computer3);

            Console.WriteLine();
            Console.WriteLine("Список сгруппированный по типу процессора");
            IEnumerable<IGrouping<string, Сomputer>> computer4 = computer.GroupBy(x => x.TypeProcessor);
            foreach (IGrouping<string, Сomputer> gr in computer4)
            {
                Console.WriteLine(gr.Key);
                foreach (Сomputer e in gr)
                {
                    Console.WriteLine($"{e.Сode} {e.Name} {e.TypeProcessor} {e.CPU} {e.RAM} {e.HardDisk} {e.VideoCardMemory} {e.Summa} {e.Quantity}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Самый дорогой компьютер");
            Сomputer computer5 = computer.OrderByDescending(x => x.Summa).FirstOrDefault();
            Console.WriteLine($"{computer5.Сode} {computer5.Name} {computer5.TypeProcessor} {computer5.CPU} {computer5.RAM} {computer5.HardDisk} {computer5.VideoCardMemory} {computer5.Summa} {computer5.Quantity}");

            Console.WriteLine();
            Console.WriteLine("Самый бюджетный компьютер");
            Сomputer computer6 = computer.OrderByDescending(x => x.Summa).LastOrDefault();
            Console.WriteLine($"{computer6.Сode} {computer6.Name} {computer6.TypeProcessor} {computer6.CPU} {computer6.RAM} {computer5.HardDisk} {computer6.VideoCardMemory} {computer6.Summa} {computer6.Quantity}");

            Console.WriteLine();
            Console.WriteLine("Eсть ли хотя бы один компьютер в количестве не менее 30 штук?");
            Console.WriteLine(computer.Any(x => x.Quantity > 30));
                                   
            Console.ReadKey();
        }
            static void Print(List<Сomputer> computers)
            {
                foreach (Сomputer e in computers)
                {
                    Console.WriteLine($"{e.Сode} {e.Name} {e.TypeProcessor} {e.CPU} {e.RAM} {e.HardDisk} {e.VideoCardMemory} {e.Summa} {e.Quantity}");
                }
                    Console.WriteLine();
            }
    }
}
