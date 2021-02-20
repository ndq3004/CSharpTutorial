using System;
using System.Collections;
using System.Threading.Tasks;
using tutorial.GenericDataStore;

namespace tutorial
{
    public delegate int Sum2Num(int a, int b);
    public delegate T Sum2NumGeneric<T>(T param1, T param2);
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(1);

            const int ConstantMax = int.MaxValue;
            int int1;
            int int2;
            int variableMax = 2147483647;

            int1 = unchecked(2147483647 + 10);

            //Array foreach
            int[] a = { 3, 5, 6, 7 };
            Array.ForEach(a, n => Console.WriteLine(n));

            var customIndexer = new DemoStorage();
            customIndexer[3] = "10";

            //Generic
            DataStore<DemoStorage> dataStore = new DataStore<DemoStorage>();
            dataStore.Data = customIndexer;
            Console.WriteLine(dataStore.Data[3]);
            UseBaseClass<ExtendClass> useBase = new UseBaseClass<ExtendClass>();
            //UseBaseClass<ExtendClassNoBase> useBase = new UseBaseClass<ExtendClassNoBase>(); //compile error because ExtendClassNoBase not references to BaseClass

            //Tuple
            var testTuple = Tuple.Create("1", "Quân", "Hello", 1);
            Console.WriteLine(testTuple.Item1);

            //Delegate
            DeligateMethods deligateMethods = new DeligateMethods();
            Console.WriteLine("Start to review delegate");
            Sum2NumGeneric<int> sumTwoNumber = delegate (int a, int b) { return a + b; };
            Console.WriteLine("Sum two number by delegate function: " + sumTwoNumber(1, 2));

            //Events with deligate and event
            Console.WriteLine("Start Event acknowledge");
            MakeEvents bl = new MakeEvents();
            bl.ProcessCompleted += Bl_ProcessCompleted;
            bl.ProcessCompleted += Bl_ProcessCompleted1;
            bl.StartProcess();

            //Event with EventHandle
            Console.WriteLine("Start event with EventHandler");
            MakeEventHandler bl_handler = new MakeEventHandler();
            bl_handler.ProcessCompleted += Bl_handler_ProcessCompleted;
            bl_handler.StartProcess();

            //Passing Event Data
            Console.WriteLine("Start event with EventHandler data");
            MakeEventHandlerWithData bl_eventHandlerData = new MakeEventHandlerWithData();
            bl_eventHandlerData.ProcessCompleted += Bl_eventHandlerData_ProcessCompleted;
            bl_eventHandlerData.StartProcess();

            //Passing custom event arg
            MakeEventHandlerWithCustomData bl_eventHandlerCustomData = new MakeEventHandlerWithCustomData();
            bl_eventHandlerCustomData.ProcessCustomCompleted += Bl_eventHandlerCustomData_ProcessCustomCompleted;
            bl_eventHandlerCustomData.StartProcess();

            //Anonymous methods
            //Có thể defind được hàm hoặc defind lại hàm run-time
            TestAnonymousMethods.DoFunction();

            //Define a nullable value
            //int intNullable = null; //get compile time error
            
            Nullable<int> intNullable = null;
            //Or use shorthand Syntax
            int? intNullable_sh = null;

            intNullable_sh = intNullable_sh ?? 30;
            if (intNullable_sh.HasValue)
            {
                Console.WriteLine(intNullable_sh);
            }
            else
            {
                Console.WriteLine("Null");
            }

            //Corvariance 
            //Big s = new Small(); //Compile time error
            corvaDel del = Corvariance.Method1;
            Small sm1 = del(new Big());

            del = Corvariance.Method2;
            Small sm2 = del(new Big()); //Pass to del delegate function a Big class object and do something, finaly return a Small class objects

            //Extensions methods
            Console.WriteLine("testing extensions methods with data type Integer");
            int k = 100;
            string isGreater = k.IsGreaterThan(k + 19) ? "yes" : "no";
            Console.WriteLine($"{k} is greater than k + 10 ? {isGreater}");

            //Task.Run(() =>
            //{
            //    var minute = DateTime.Now.Minute;
            //    while(minute < 18)
            //    {
            //        minute = DateTime.Now.Minute;
            //    }
            //    Console.WriteLine("Finish Task");
            //});

            Task t = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Start run Task run by StartNew");
                var minute = DateTime.Now.Minute;
                while (minute < 20)
                {
                    minute = DateTime.Now.Minute;
                }
                Console.WriteLine("Finish Task run by StartNew");
            });
            Console.WriteLine("Start wait Task run by StartNew");
            t.Wait(1000);


            Console.WriteLine("Run outer Task");
            Console.ReadKey();
            Console.WriteLine();
        }

        private static void Bl_eventHandlerCustomData_ProcessCustomCompleted(object sender, ProcessEventArg e)
        {
            if(e != null)
            {
                Console.WriteLine(e.IsSuccessfull ? "Process successfully!" : "Process unsuccesfully!");
            }
        }

        private static void Bl_eventHandlerData_ProcessCompleted(object sender, bool e)
        {
            Console.WriteLine(e ? "Process successfully!" : "Process unsuccesfully!");
        }

        private static void Bl_handler_ProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("On completed event with event handler!");
        }

        private static void Bl_ProcessCompleted1()
        {
            Console.WriteLine("Process completed 2!");
        }

        private static void Bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed 1!");
        }
    }
}
