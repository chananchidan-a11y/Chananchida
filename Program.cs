using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator
{
namespace GradeCalculator
    {
        class Program
        {
            static void Main()
            {
                while (true) // วนลูปโปรแกรมใหม่เสมอ
                {
                    Console.Clear();
                    Console.WriteLine("=== โปรแกรมคำนวณเกรด ===");
                    Console.WriteLine("พิมพ์ 'exit' เพื่อออกจากโปรแกรม\n");

                    Console.Write("กรุณากรอกคะแนน (0-100): ");
                    string input = Console.ReadLine();

                    // คำสั่งออกจากโปรแกรม
                    if (input.Trim().ToLower() == "exit")
                    {
                        Console.WriteLine("\nออกจากโปรแกรม...");
                        break;
                    }

                    // ตรวจสอบว่ากรอกเป็นตัวเลขหรือไม่
                    if (!int.TryParse(input, out int score))
                    {
                        Console.WriteLine("\n** ข้อผิดพลาด: กรุณากรอกเป็นตัวเลข! **");
                        Pause();
                        continue;
                    }

                    // ตรวจสอบช่วงคะแนน
                    if (score < 0 || score > 100)
                    {
                        Console.WriteLine("\n** ข้อผิดพลาด: คะแนนต้องอยู่ระหว่าง 0 ถึง 100 **");
                        Pause();
                        continue;
                    }

                    // คำนวณเกรด
                    string grade = CalculateGrade(score);

                    Console.WriteLine($"\nคะแนน {score} ได้เกรด: {grade}");

                    Pause();
                }
            }

            // ฟังก์ชันคำนวณเกรด
            static string CalculateGrade(int score)
            {
                if (score >= 80) return "A";
                else if (score >= 75) return "B+";
                else if (score >= 70) return "B";
                else if (score >= 65) return "C+";
                else if (score >= 60) return "C";
                else if (score >= 55) return "D+";
                else if (score >= 50) return "D";
                else return "F";
            }

            // ฟังก์ชันหยุดรอผู้ใช้กดปุ่ม
            static void Pause()
            {
                Console.WriteLine("\nกดปุ่มใดๆ เพื่อดำเนินการต่อ...");
                Console.ReadKey();
            }
        }
    }

        
        }

   
