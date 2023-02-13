using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // 추가
using System.Net; // 추가
using System.Net.Sockets; // 추가
using System.IO; // 추가

namespace TurnTable_WinApp
{
    public partial class Form1 : Form
    {
        //Network var
        string ID;
        NetworkStream stream = default(NetworkStream);
        TcpClient client = new TcpClient();
        //
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(connect); // Thread 객채 생성, Form과는 별도 쓰레드에서 connect 함수가 실행됨.
            thread1.IsBackground = true; // Form이 종료되면 thread1도 종료.
            thread1.Start(); // thread1 시작.

        }
        private void degree_btn_Click(object sender, EventArgs e)
        {
            writeLogBox("Deg. : " + degreeTextBox.Text);
        }
        private void repeat_btn_Click(object sender, EventArgs e)
        {
            writeLogBox("Repeat. : " + repeatTextBox_lower.Text + " to " + repeatTextBox_upper.Text);
        }
        private void speed_btn_Click(object sender, EventArgs e)
        {
            int speed = -1;
            try
            {
                speed = Int32.Parse(speedTextBox.Text);
                if (speed < 1 || speed > 10)
                {
                    writeLogBox("Please try valid number (1 ~ 10)");
                }
                else
                {
                    writeLogBox("Speed : " + speedTextBox.Text);
                    Console.WriteLine(speed);
                }
            } catch(FormatException err)
            {
                Console.WriteLine(err.Message);
                writeLogBox("Please use number (1 ~ 10)");
            }

        }
        private void connect()
        {
            writeLogBox("서버 준비...클라이언트 기다리는 중...");
            writeLogBox("IP : "+ipTextBox1.Text + "." + ipTextBox2.Text + "." + ipTextBox3.Text + "." + ipTextBox4.Text);
            writeLogBox("PORT : " + portTextBox.Text);
            /*
            TcpListener tcpListener1 = new TcpListener(IPAddress.Parse(textBox1.Text), int.Parse(textBox2.Text)); // 서버 객체 생성 및 IP주소와 Port번호를 할당
            tcpListener1.Start();  // 서버 시작
            writeRichTextbox("서버 준비...클라이언트 기다리는 중...");

            TcpClient tcpClient1 = tcpListener1.AcceptTcpClient(); // 클라이언트 접속 확인
            writeRichTextbox("클라이언트 연결됨...");

            streamReader1 = new StreamReader(tcpClient1.GetStream());  // 읽기 스트림 연결
            streamWriter1 = new StreamWriter(tcpClient1.GetStream());  // 쓰기 스트림 연결
            streamWriter1.AutoFlush = true;  // 쓰기 버퍼 자동으로 뭔가 처리..

            while (tcpClient1.Connected)  // 클라이언트가 연결되어 있는 동안
            {
                string receiveData1 = streamReader1.ReadLine();  // 수신 데이타를 읽어서 receiveData1 변수에 저장
                writeRichTextbox(receiveData1); // 데이타를 수신창에 쓰기                  
            }
            */
        }
        private void writeLogBox(string str)
        {
            LogBox.Invoke((MethodInvoker)delegate { LogBox.AppendText(str + " \r\n"); }); // 데이타를 수신창에 표시, 반드시 invoke 사용. 충돌피함.
            LogBox.Invoke((MethodInvoker)delegate { LogBox.ScrollToCaret(); });  // 스크롤을 젤 밑으로.
        }
        private void clearLogBox()
        {
            LogBox.Clear();
        }

        private void logClear_btn_Click(object sender, EventArgs e)
        {
            clearLogBox();
        }


    }

}
