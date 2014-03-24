using System;

namespace ProgExWeek3
{
	class Student
	{
		public string Name;
		public int Korean;
		public int English;
		public int Mathmatics;
		public int Science;

		// 이름, 국어, 영어, 수학, 과학 점수를 
		// 인자로 받는 생성자를 만드세요
		public Student(String Name1, int Korean1, int English1, int Mathmatics1, int Science1)
		{
			Name = Name1;
			Korean = Korean1;
			English = English1;
			Mathmatics = Mathmatics1;
			Science = Science1;
		}

		public int Average() {
			// 평균을 구하세요.
			int avrg = (Korean + English + Mathmatics + Science) / 4;
			return avrg;
		}
	}

	class Average
	{
		public static void Main (string[] args)
		{
			Student student1 = new Student ("Dahye Kim", 10, 20, 30, 40);
			// 이름과 평균을 출력하세요. 
			Console.WriteLine ("이름 : {0}, 평균: {1}",student1.Name, student1.Average ());
		}
	}
}

