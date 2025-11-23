using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class InvalidScoreException : Exception // GPT가 사용자 예외 사용하려면 클래스 생성해야한다고 말해서 짜줌.
        {
            public InvalidScoreException(string message)
                : base(message)
            {
            }
           
        }
        private int InputScore(string text) 
        {
            int value;
           
                if (!int.TryParse(text, out value)) // 텍스트를 받아서 밸류에 인트형식으로 넣어 실패하면 0 근데 앞에 NOT 때문에 실패하면 1 
                {
                    throw new FormatException("점수는 숫자이여야 합니다.");// FormatException 발생시켜서 "점수는 숫자이어야 합니다"
                }
                if (value < 0 || value > 100) // 들어간 숫자의 사이즈 확인후 예외던지기
                {
                    throw new InvalidScoreException("점수는 0~100 사이이어야 합니다"); // 예외를 발생 : InvalidScoreException : 점수는 0~100 사이이어야 합니다
                }

                return value; // 점수받아서 체크 후 반환... 밑에있는 if문과 겹치는것 같음. 한번더 체크용
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           try
            {
                //칸 안에 입력한 것들 전부 String 으로 각자의 변수안에 넣는다.
                string id = txtId.Text; 
                string name = txtName.Text;
                string korStr = txtKor.Text;
                string engStr = txtEng.Text;
                string mathStr = txtMat.Text;
                int value;

             if (string.IsNullOrEmpty(id)) // 아이디가 null이거나 아무것도 안넣으면 밑 에러 출력 
                {
                    throw new FormatException("ID를 바르게 입력하세요.");
                }
                //이름, 국어점수, 영어점수, 수학점수 : 값이 입력이 되었는지 체크, 아니면 예외처리
                //FormatException
                if (string.IsNullOrEmpty(name)) // 아이디처럼 null이거나 아무것도 안넣었니?
                {
                    throw new FormatException("이름를 바르게 입력하세요.");
                }

                if (!int.TryParse(korStr, out value)) //위에 점수는 숫자여야 합니다 if문 참조.
                {
                    throw new FormatException("점수는 숫자이여야 합니다.");
                }
                else if (value < 0 || value > 100) 
                {
                    throw new InvalidScoreException("점수는 0~100 사이이어야 합니다");
                }

                if (!int.TryParse(engStr, out value))
                {
                    throw new FormatException("점수는 숫자이여야 합니다.");
                }
                else if (value < 0 || value > 100) 
                {
                    throw new InvalidScoreException("점수는 0~100 사이이어야 합니다");
                }

                if (!int.TryParse(mathStr, out value))
                {
                    throw new FormatException("점수는 숫자이여야 합니다.");
                }
                else if (value < 0 || value > 100) 
                {
                    throw new InvalidScoreException("점수는 0~100 사이이어야 합니다");
                }
                // 더 이쁘게 짜고싶은데 방법을 모르겠습니다.
                value = 0;

                int kor = InputScore(korStr);
                int eng = InputScore(engStr);
                int math = InputScore(mathStr);

                dgbStudent stu = new dgbStudent(); // 제대로 수정
                                                   //데이터 그리드뷰에 학생 추가 : 강사제공

                //총학생수 : lblTot값을 입력한 학생의 수로 업데이트
                //???를 스튜던트 클래스에서 델리게이터->필드(변수)로 선언
                stu.TotalCount++;
                lblTot.Text = stu.TotalCount.ToString();

                ClearInput();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("점수는 숫자이여야 합니다.");
            }
            catch(InvalidScoreException ex) 
            {
                MessageBox.Show("점수는 0~100 사이이어야 합니다");
            }
        }
        //모든 텍스트 박스의 내용을 초기화
        private void ClearInput()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtKor.Text = "";
            txtEng.Text = "";
            txtMat.Text = "";
        }
    }
}
