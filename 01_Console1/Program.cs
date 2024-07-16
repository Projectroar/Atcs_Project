using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _01_Console
{


    // C#의 메모리 구조
    // 구분 : Heap 메모리, Stack 메모리
    // Heap : 운영체제가 관리하는 메모리, 크기가 매우 크다, 속도 느림 - class가 저장 레퍼런스타입
    // Stack : 프로그램이 실행되었을 떄 이미 할당 받은 메모리 크기가 작다, 속도 빠름 struct(구조체)가 저장됨 벨리타입
    // ArrayList 사용X
    // 가비지컬렉터로 자동으로 메모리할당해제

    // 얕은 복사는 주소만 넘겨주는것(주소만 가져오는 계념인듯)

    // 참조타입(Reference type) : 얕은 복사 - 한쪽을 변경시키면 다른쪽도 같은 값이된다
    // 값타입(Value type) : 깊은 복사 속도는 느리지만 실체가 복사한 만큼 생긴다

    // static : 정적. 프로그램 실행전 결정되어 있는 것
    // class, 함수

    // dynamic : 동적. 프로그램 실행 중에 결정되는 것

    internal class Program
    {
        enum PointGrade
        {
            A,
            B,
            C,
            D,
            F
        }
        enum Test
        {
            A,B,C, D, E
        }
        enum AgeCategory
        {
            Child, Elemetry, Middle , High, Adult
        }
        static void gogo1(int asd)//받을 정수형
        {
            Console.WriteLine($"{asd}단 출력");
        }


    
        static void Main(string[] args)
        {
            //7/16----------------------------------------------


            //c# 한정 internal 이란 것도 있음
            // 접근제한자(Access Modifier)
            // Class 선언 후 사용 시 메인에서 부름
            // 같은 클래스를 불러 new(메모리할당)로 다른이름(객체)의 변수로 만들 수 있다
            //클래스에는 상속 계념이 있다
            //접근제한자 class 상속받을클래스이름 : 상속하는클래스이름
            //상속받은 클래스를 자식, 상속하는 클래스를 부모
            //public : 모두 사용가능한 
            //private : 자신만 사용할 수 있는 (상속해도 사용 불가능)
            //protected : 자신과 자신을 상속 받은 곳에서만 사용가능

            //객체지향 : 여러사람이 같이 사용하기 좋은 방법
            //오브젝트를 따로 제작 


            // 반복문 
            // while
            /*int count = 0;
            while (count < 3) // while : ()사이의 조건이 참이면 계속 반복해서 {}안의 내용을 실행
            {
                Console.WriteLine("aaa");
                count++;
            }

            do
            {
                Console.WriteLine("aaa");
                count++;
            } while (count < 3); // {}사이의 코드를 먼저실행 한 뒤 ()조건이 참이면 반복

            for(int i = 0; i < 3; i++) // for(초기화; 조건부;증감부)
            {
                Console.WriteLine("iii");
            }
            // 배열(Array) : 같은 종류의 데이터타입을 가지는 값들을 하나로 묶어놓은 것
            int[] intArray;
            intArray = new int[3]; // new : 할당
            intArray[0] = 1;
            intArray[1] = 2;
            intArray[2] = 3;
            
            foreach(int i in intArray)//처리속도 빠름
            {
                Console.WriteLine($"{i}");
            }*/

            // 실습
            // 구구단 출력
            // 1. 숫자입력받기(숫자 변경 실패하면 다시 받기)
            // 2. 입력 받은 숫자의 구구단 출력하기
            // 3. 파라메터를 받은 숫자의 구구단 출력하는 함수 만들기

            bool isSuccess = false; //불리얼 false
            int result = 0;//int형변수 
            int gogo = 1;
            do//첫실행 
            {
                Console.WriteLine("숫자입력");
                isSuccess = int.TryParse(Console.ReadLine(), out result);//정수형을 입력 받을경우 종료 정수가 아닐경우 반복

            } while (!isSuccess);//정수형아닐시 반복
            Console.WriteLine($"{result}단 출력");
            for (gogo = 1; gogo < 10; gogo++)
            {
                Console.WriteLine($"{result} * {gogo} = {result * gogo}");
            }

            gogo1(result);//부를 함수를 기능 단위로 분리 할 것

           /* int[] intArray2 = new int[10];

            for (int dan = 2; dan < 10; dan++)
            {
                for (int i = 1; i < 10; i++)
                {
                    intArray2[i] = dan * i;
                    
                }
                Console.WriteLine($"{dan} * {i} = {intArray2[dan]}");
            }*/








            //7/15 -------------------------------
            //실습 2
            //1. 나이입력
            //2. 8살미만 "미취학 아동"
            //3. 13미만 "초등학생"
            //4. 16미만 " 중학생"
            //5. 19살 미만 "고등학생"
            /*Console.Write("나이를 입력하세요 : ");
            int age = 0;
             string agestr = Console.ReadLine();//문자열 입력
            age = int.Parse(agestr);// 문자열 형변환
            //int categoty = 0; //매직넘버 사용X

            AgeCategory ageCategory;
            if (age < 8)
            {
                Console.WriteLine("미취학 아동");
                ageCategory = AgeCategory.Child;
            }
            else if( age < 13)
            {
                Console.WriteLine("초등학생");
                ageCategory = AgeCategory.Elemetry;
            }
            else if (age < 16)
            {
                Console.WriteLine("중학생");
                ageCategory = AgeCategory.Middle;
            }
            else if (age < 19)
            {
                Console.WriteLine("고등학생");
                ageCategory = AgeCategory.High;
            }
            else
            {
                Console.WriteLine("성인");
                ageCategory = AgeCategory.Adult;
            }*/

            //switch : () 사이에 있는 값에 따라 다른 코드를 수행하는 조건문
            /*switch(categoty)
            {
                case 0:Console.WriteLine("1000원");  break;
                case 1: Console.WriteLine("2000원"); break;
                case 2: Console.WriteLine("3000원"); break;
                case 3: Console.WriteLine("4000원"); break;
                case 4: Console.WriteLine("5000원"); break;
            }*/

            /*switch (ageCategory)
            {
                case AgeCategory.Child:
                    break;
                case AgeCategory.Elemetry:
                    break;
                case AgeCategory.Middle:
                    break;
                case AgeCategory.High:
                    break;

                       
            }
            Console.Write("입력창");
            int input = 0;
            Test testinpuT = Test.A;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input == 0)
                {
                    Console.WriteLine(input);
                    testinpuT = Test.A;
                }
                else
                {
                    Console.WriteLine(input);
                    testinpuT = Test.B;
                }
            }
            switch (testinpuT)
            {
                case Test.A:
                    Console.WriteLine("A");
                    break;
                case Test.B: Console.WriteLine("B"); break;
            }*/
            /*int point;
            if(int.TryParse(Console.ReadLine(), out point))//TryParse 는 bool타입 out는 마지막 값만 리턴
            {
                Console.WriteLine("정상 변환");
            }
            else
            {
                Console.WriteLine("변환 실패");
            }*/

            //실습
            //1. 성적용 enum 만들기 (A,B,C,D,F)
            //2. 점수를 입력 받아서 90점 이상이면 A, 80이상이면 B, 70점 이상이면 C, 60점 이상이면, D, 60점 미만일경우 F
            /*Console.WriteLine("점수 입력");
            int test = 0;
            PointGrade pointGrade = PointGrade.F;
            if (int.TryParse(Console.ReadLine(), out test))
            {
                if (test > 89)
                {
                    pointGrade = PointGrade.A;
                }
                else if (test > 79)
                {
                    pointGrade = PointGrade.B;
                }
                else if (test > 69)
                {
                    pointGrade = PointGrade.C;
                }
                else if (test > 59)
                {
                    pointGrade = PointGrade.D;
                }
                else { pointGrade = PointGrade.F; }
                
                Console.WriteLine($"당신{test}");
                

            }
            switch (pointGrade)
            {
                case PointGrade.A: Console.WriteLine("A");
                    break;
                case PointGrade.B:
                    Console.WriteLine("B");
                    break;
                case PointGrade.C:
                    Console.WriteLine("C");
                    break;
                case PointGrade.D:
                    Console.WriteLine("D");
                    break;
                case PointGrade.F:
                    Console.WriteLine("F");
                    break;

            }*/












            //제어문(Control statemnt) - 조건문(if, switch), 반복문 (Wiher, For)
            //연산자(operator)
            //산술연산자 : + - * / %, 산수 계산
            // 대입연산자 : =, = 오른쪽에 있는 값을 왼쪽 변수에 대입하는 연산자
            // 비교연산자 : <, >, <=, >=, ==, !=, 결과는 true 아니면 false

            //float 타입을 == 비교할 시 오차 매우 심함
            // 절대로 float 같은 실수 타입을 ==로 비교 하지말것
            //논리연산자 : &&(and)연산자 좌우측이 모두 true일때 true,||(or)연산자 좌우측 중 1개만 true 일때 true, 항상 결과는 true 아니면 false
            // 비트연산자 : &(and,오른쪽에 있는 비트와 왼쪽에 있는 비트가 모두 1일때 1), |(or,좌우측 비트중 하나만 1이면 1);

            //int ee = 123;
            //ee = 0b_0111_1011; //이진수로 쓴 123
            //증감연산자 : ++, --, +=, -=, *=, /=
            //a += 10 = a = a + 10;
            //후위 전위 : q++, ++q 




            /*int age = 24;
            
           
            if (age >= 20)//비추천 2번 확인함
            {
                Console.WriteLine("성인입니다");
            }
            else { Console.WriteLine("성인아님"); }


            if(age < 21)//추천
            {
                Console.WriteLine("성인임");
            }
            else { Console.WriteLine("성인아님"); }*/
            //if -else : ()사이에 있는 조건이 true면 if아래에 있는 {} 사이의 코드 실행 아니면 else실행



            //리턴타입
            /*int t = 20;
            Console.WriteLine("으어{0}아아" + t + "절대비추");
            Console.WriteLine("우어어{0}아아",t);
            Console.WriteLine($"우어엉{t}dkdk"); // 합칠 떄는 앞에 달러표시  변수는 중괄호 안에*/


            //C# 값 타입 : 스택 메모리 저장, int,float, bool, 기타구조체
            //C# 참조타입 : 힙 메모리 저장, string,기타 클래스
            // NULL : 비어있다, 값이 없는 = 기본적으로 참조타입만 가능
            // nullable type : 값 타입에 붙을 수있는 null

            /*int?  y;//y는 널
            y = 10;//y는 10*/

            // 문자형? 변수 / 언어버전 8.0부터 지원
            //string trww  = Console.ReadLine();// 입력한 값 출력
            //Console.WriteLine(trww);//여기서 출력

            //실습
            //1. 이름 입력받기 (" 이름을 입력하세요 : ");
            //2. 나이 입력받기 ("나이를 입력하세요 : ")
            //3. 주소 입력받기 ("사는 곳을 입력하세요 : ")
            //4. 이름, 나이, 주소를 한번에 출력하기
            /*Console.Write("이름을 입력하세요 : ");//Line을 빼면 줄바꿈 안됨
            string name =  Console.ReadLine();
            Console.WriteLine("나이를 입력하세요 : ");
            string s = Console.ReadLine();
            Console.WriteLine("주소를 입력하세요 : ");
            string jj = Console.ReadLine();

            Console.WriteLine($"이름 : {name}, 나이 : {s}, 주소 : {jj}");*/

            //함수 이름 : 다른 함수와 구분하기 위한 것(사람용)
            // 파라메터 : 함수를 실행하는데 필요한 데이터 (0개 이상)
            // 리턴타입 : 함수가 종료되었을 때 돌려주는 데이터 타입(void는 리턴값의 의미)

            /*string qqq = Console.ReadLine();
            int age = int.Parse(qqq);
            int.TryParse(age);*///Parse, TryParse


            //7 12------------------------------------

            //
            /*
             */
            ///

            //디버깅용 단축키
            //F9 브레이크 포인트 지정
            //F5 디버그 모드로 시작. 디버깅 중일 떄는 다음 브레이크 포인트까지진행
            //F10 현재 멈춰있는 지점에서 다음 점으로 넘어가기

            //편집용 단축키
            //Ctrl+ D 현재코드를 한줄 복사해서 붙여넣기
            // Shift + Del 현재줄 지우기
            // Ctrl + 좌우화살표 단어 단위로 이동
            // Ctrl + 위아래화살표 커서 위치는 그대로 두고 페이지를 위아래로 움직이기

            //Console.WriteLine("Hello, World!");

            // 변수 데이터를 저장해 놓는 곳(메모리에서의 위치)
            //함수 특정한 기능을 수행하는 코드덩어리
            //클래스 특정한 동작을 하는 물체를 표현하기 위해 변수와 함수를 모아 놓은 것

            //데이터 타입 : 변수의 종류
            // 정수 Integer 소수점이 없는숫자 
            // 실수 Float 소수점이 있는숫자
            // 불리언 boolean true,false
            // 문자열 string 여러문자

            //int a = 10;//정수는 실수 못씀

            //float b = 20.5f;//float 는 8byte라 int 데이터도 들어감
            //bool c = true;
            //string d = "qweeq";


        }
    }
}
