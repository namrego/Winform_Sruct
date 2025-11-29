using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_struct
{
    public struct Score // 스코어 담을 클래스
    {
        public int Kor;
        public int Eng;
        public int Math;

        public Score(int k, int e, int m) //생성자
        {
            Kor = k;
            Eng = e;
            Math = m;
        }
        public int Total() => Kor + Eng + Math; // 토탈은 3개 다 더한거다.
        public double Avg() => Total() / 3.0; // avg는 토탈나누기 3
        
    }
    public interface IPerson // 인터페이스 선언
    {
        string GetInfo();
    }
    
    public class Person : IPerson // 인터페이스 상속받음 GetInfo 가능
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Person(string id, string name) // Person은 id , name 받음
        {
            Id = id;
            Name = name;
        }
        public virtual string GetInfo() // getinfo하면 id랑 이름 나옴.
        {
            return $"ID : {Id}, 이름 : {Name}";
        }
    }
    public class Student : Person // IPerson>Person>Student 관계
    {
        public Score score { get; set; }
        public static int TotalCount = 0; //수정해야 총 학생수로 동작함 // 복습 모든 클래스 전체가 이 값을 공유함.
        public Student(string id, string name, int kor,int eng, int math) : base(id, name) // 스튜던트는 id name kor eng math 받음 부모의 id name 공유
        {
            score = new Score(kor, eng, math); // 스코어는 모든 점수 들어감
        }

        public override string GetInfo() //부모 GetInfo 내가 새로 조정함.
        {
            return $"ID : {Id}, 이름 : {Name}, 총점 : {score.Total()}, 평균 : {score.Avg()}"; // ID 이름 총점 평균 총점과 평균은 위에 만든 람다식 가져옴
        }
    }
    
     
}
