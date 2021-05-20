// 접근지정자 (static 생략가능) 리턴타입 함수이름() { }

//리턴 타입 : void -> 리턴이 없다
//그 외, 리턴 타입 string, int, ...등등


// static void    vs      void

namespace x_n
{
    class Program
    {
        class Dog
        {
						// static없는 메소드는 없는 것 끼리 논다
						// static은 static끼리 논다
            public void fun1()
            {
                Console.WriteLine("fun1");
                fun3(); // fun3()도 static을 사용하지 않기 때문에 가능
            }

            public static void fun2()
            {
                Console.WriteLine("fun2");
                fun4(); // fun4()도 static을 사용하기 때문에 가능
            }

            public void fun3()
            {
                Console.WriteLine("fun3");
            }

            public static void fun4()
            {
                Console.WriteLine("fun3");
            }
        }
        public void test()  // void는 스택에 
        {
            Console.WriteLine("어떻게쓸까요?");
        }

        public static void test2() // static은 힙에
        {
            Console.WriteLine("어떻게쓸까요?");
        }

        static void Main(string[] args)
        {
						// Dog 클래스에서
            Dog dog = new Dog();
            dog.fun1(); //static 없을 땐 객체 생성 후 -> 객체.함수();

            Dog.fun2(); //static쓰면 객체 만들 필요 x -> 클래스.함수();


						// Program 클래스에서
            Program program = new Program();
            program.test(); // static이 없을 때

            Program.test2(); // Program 생략 가능. 같은 Program 클래스니까
            test2(); // static있을 때
