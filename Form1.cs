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
        private int InputScore(string text)
        {
            int value;
            if (!int.TryParse(text, out value))
            {
                throw new FormatException("점수는 숫자이여야 합니다.");// FormatException 발생시켜서 "점수는 숫자이어야 합니다"
            }
            if (value<0 || value>100)
            {
                throw new InvalidScoreException("점수는 0~100 사이이어야 합니다");// 예외를 발생 : InvalidScoreException : 점수는 0~100 사이이어야 합니다
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           try
            {
                string id = txtId.Text;
                string name = txtName.Text;
                string korStr = txtKor.Text;
                string engStr = txtEng.Text;
                string mathStr = txtMat.Text;

             if (string.IsNullOrEmpty(id))
                {
                    throw new FormatException("ID를 바르게 입력하세요.");
                }
                //이름, 국어점수, 영어점수, 수학점수 : 값이 입력이 되었는지 체크, 아니면 예워처리
                FormatException
                if (???)
                {
                    ???
                }
                if (???)
                {
                    ???
                }
                if (???)
                {
                    ???
                }
                if (???)
                {
                    ???
                }
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
                ???
            }
            catch(InvalidScoreException ex) 
            {
                ???
            }
        }
        //모든 텍스트 박스의 내용을 초기화
        private void ClearInput()
        {
            return???
        }
    }
}
