using System;
using A;
using B;
// 해당 네임 스페이스를 사용한다 (using A)

// 클래스 이름은 사용자 정의 데이터를 의미합니다.
class GParent
{
    public int iData;
    // private, protected, public
    // private : 외부에서 호출할 수 없는 형태
    // protected : 상속을 받은 객체까지만 호출할 수 있는 형
    // public : 외부에서 호출할 수 있는 형태
    // static붙은 정적함수는 프로그램이 구동될 때 식별할 수 있는 형태의 함수이다

    // 일반 함수와 정적 함수의 차이 -------------------------------------------------
    // 일반 함수는 사용하고자 할 때 클래스 변수를 먼저 생성하고 클래스 변수에서 호출할 수 있는 형태
    // 정적 함수는 클래스 식별 타입만 정의를 해두고 . 표시를 한 이후 사용될 수 있는 형태를 갖는다.
    public void Test()
    {
    }
    private void Private_Test()
    {
    }
    public static void sTest()
    {

    }
}
class Parent : GParent
{

}

class Child : Parent
{
    private void CTest()
    {
        Test();
    
    }
}


namespace ConsoleApp01
{
    // 구조체
    struct BBB
    {

    }
    class AAAA
    {
        // 리턴 타입은 함수가 종료전에 되돌려 줄 값을 의미합니다.
        // 리턴 타입이 void 라는 것은 함수가 종료될 때 리턴해줄 값이 필요없다는 의
        static int GetInt()
        {
            int check = 10;
            return check;
        }
        int ia; // 정수를 담을 수 있는 데이터 : 음수, 0, 양수
        char ch; // 하나의 문자를 담을 수 있는 데이터
        string str; // 문자열을 담을 수 있는 데이터
        byte by;  // 한 바이트를 담을 수 있는 데이터
        bool bType;  // 참, 거짓을 식별하기 위한 변수
        float fType;  // 실수 : 소수점 6자리까지 보정해주는 실수
        double dType; // 실수
        decimal deci; // 실
    }


    class Program
    {
        // 함수는 아래의 형태로 구성되어 집니다.
        // 함수의 소괄호에 들어가는 변수를 매개변수라고 합니다.
        // 함수는 사용자의 사용에 따라 
        // 접근지정자 리턴값 함수이름()
        // 함수는 리턴 타입, 함수의 이름, 소괄호, 소괄호내의 매개 변수를 갖고
        // 중괄호의 시작과 끝으로 {} 표현된다.



        // static 변수가 붙은 함수를 정적 함수라고 하며,
        // static 키워드가 붙은 변수를 정적 변수라고 합니다.

        // 메인 함수는 컴파일러에서 자동으로 호출해주는 함수 (외부에서 호출되는 함수)
        // c#의 메인함수는 반드시 정적함수도 구현되어야 한다. (static 키워드를 붙여야 한다.)
        // 이름은 반드시 Main 이어야 하고 메인 함수는 지원되는 표기방식이 있다.
        static void Main(string[] args)
        {
            // 사용하기 위한 변수를 선언함과 동시에 메모리를 부여합니다.
            GParent c = new GParent();

            // 변수 이름은 의미를 설명하는 이름으로 지정해줘야 합니다.
            // 변수 이름이 너무 길면 직관적이지 않기 때문에 짧게 지정해주세요.
            // 대소문자 구성을 일관되게 하는 것이 좋습니다.

            int data = 1;
            float fdata = 1.077f;

            // 데이터 타입 뒤에 [] (대괄호가 붙츤) 데이터를 배열이라고 합니다.
            // 배열은 할당을 할 때 반드시 사이즈값을 넣어주셔야 합니다.
            // int 타입이 세개 나열된 데이터, 4byte * 3 = 12byte 메모리 영역을 갖습니다.
            // []가 붙어 있다면 메모리가 순차적으로 나열된 공간이다.
            int[] arr = new int[3] { 1, 2, 3 };

            Console.WriteLine("Hello World!");

            Test test = new Test();

            A.Mover mover = new A.Mover();
            B.Mover mover2 = new B.Mover();

            GParent.sTest();
            Child child = new Child();
            int ival = child.iData;

            Console.WriteLine(data);
            Console.Write("\n");
            Console.WriteLine(data);
            Console.WriteLine("\n");
            Console.WriteLine(fdata);
            Console.Write("\n");
            Console.WriteLine(data);
        }
    }
}
