using System;
using System.Text;
using System.Management;
using System.Web.Security;
using System.IO;


namespace Hownet.BLL
{
    public class GetHDID
    {
        public static byte[] Rand
        {
            get
            {
                GetHDID hd = new GetHDID();
                byte[] _rand = hd.GetRand();
                return _rand;
            }
        }
        public static bool IsReg = false;
        public string GetNumChar(int strLength)
        {
            char[] numchar = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            System.Text.StringBuilder newRandom = new System.Text.StringBuilder(10);
            Random rd = new Random();
            for (int i = 0; i < strLength; i++)
            {
                newRandom.Append(numchar[rd.Next(10)]);
            }
            return newRandom.ToString();
        }
        public byte[] GetRand()
        {
            byte[] tem = new byte[8];
            for (int i = 0; i < 8; i++)
            {
                tem[i] = byte.Parse(GetNumChar(2));
            }
            return tem;
        }
        public bool Reg()
        {
            try
            {
                int[] KeyHandle = new int[8];
                int[] KeyNumber = new int[1];
                bool t = true;

                long APPID = 0x19800327;//Ӧ�ó����ʶ�ɹ�����)��

                //���Ҽ�����
                int Rtn = DogAPI.NoxFind((int)APPID, KeyHandle, KeyNumber);
                if (KeyNumber[0] == 0)
                {
                    t = false;
                }

                //�򿪼����� �û������ɹ�������
                string uPin = "008e86f2a3434757";
                Rtn = DogAPI.NoxOpen(KeyHandle[0], uPin);
                if (Rtn > 0)
                {
                    t = false;
                }
                return t;
            }
            catch (Exception ex)
            {
                return true;
            }
        }
        public static string md5One()
        {
            ComputerSn CS = ComputerSn.Instance();
            string cn = FormsAuthentication.HashPasswordForStoringInConfigFile(CS.CpuID, "Md5");
            // string di = FormsAuthentication.HashPasswordForStoringInConfigFile(CS.DiskID, "Md5");
            string mac = FormsAuthentication.HashPasswordForStoringInConfigFile(CS.MacAddress, "Md5");
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < cn.Length; i++)
            {

                str.Append(cn[i].ToString());
                //  str.Append(di[i].ToString());
                str.Append(mac[i].ToString());
            }
            return str.ToString();
        }
        public static int _linesCount = 0;
        /// <summary>
        /// ��Ȩ����,-1Ϊδע�ᣬ99Ϊ�������û���
        /// </summary>
        public static int LinesCount
        {
            set
            {
                _linesCount = value;
            }

            get
            {
                return _linesCount;
            }

        }
        /// <summary>
        /// �ͻ���
        /// </summary>
        public static string ClientName
        {
            set;
            get;
        }
        public static string _liness = string.Empty;

        public  string GetLiness()
        {
           
                return _liness;
            
        }
        private static string _appDir = System.Windows.Forms.Application.StartupPath;

        public static string AppDir
        {
            get
            {
                return _appDir;
            }
        }
        public static void CheckReg()
        {
            Hownet.BLL.BaseFile.PassWord bllPW = new Hownet.BLL.BaseFile.PassWord();
            //  string aa = bllPW.Encrypt("��������", "howneter");
            if (File.Exists(AppDir + @"\licenses.bin"))
            {

                FileStream filestream = new FileStream(AppDir + @"\licenses.bin", FileMode.Open, FileAccess.Read);
                //byte[] bb = new byte[filestream.Length];
                //BinaryReader r = new BinaryReader(filestream);
                //r.BaseStream.Seek(0, SeekOrigin.Begin);    //���ļ�ָ�����õ��ļ���
                //bb = r.ReadBytes((int)r.BaseStream.Length);
                //byte[] bl = new byte[8];
                //for (int i = bb.Length - 8; i < bb.Length; i++)
                //{
                //    bl[i - (bb.Length - 8)] = bb[i];
                //}
                //string bbl = bllPW.Decrypt(Convert.ToBase64String(bl), "howneter");
                ////  string aa= Convert.ToBase64String(bb);

                //byte[] bblion = new byte[Convert.ToInt32(bbl)];
                //for (int i = 0; i < bblion.Length; i++)
                //{
                //    bblion[i] = bb[i];
                //}
                //filestream.Close();



                byte[] bb = new byte[filestream.Length];
                BinaryReader r = new BinaryReader(filestream);
                r.BaseStream.Seek(0, SeekOrigin.Begin);    //���ļ�ָ�����õ��ļ���
                bb = r.ReadBytes((int)r.BaseStream.Length);
                byte[] bl = new byte[8];
                for (int i = bb.Length - 8; i < bb.Length; i++)
                {
                    bl[i - (bb.Length - 8)] = bb[i];
                }
                string bbl = bllPW.Decrypt(Convert.ToBase64String(bl), "howneter");
                //  string aa= Convert.ToBase64String(bb);

                byte[] bblion = new byte[Convert.ToInt32(bbl)];
                for (int i = 0; i < bblion.Length; i++)
                {
                    bblion[i] = bb[i];
                }
                string ss = bllPW.Decrypt(Convert.ToBase64String(bblion), "howneter");
   
                filestream.Close();




                //string ss =bllPW.Decrypt(Convert.ToBase64String(bblion), "howneter");
                string li = ss.Substring(0, ss.IndexOf("----"));
                string md = md5One();
                if (ss.Substring(0, ss.IndexOf("----")) == md5One())
                {
                    int aa = ss.IndexOf("----");
                    try
                    {
                        ClientName = ss.Substring(aa + 4, ss.Length - 6 - aa-10);
                    }
                    catch (Exception ex)
                    {
                    }
                    LinesCount = Convert.ToInt32(ss.Substring(ss.Length - 12,2));
                    _liness = ss.Substring(ss.Length - 10);
                }
                else
                {
                    LinesCount = -1;
                }

            }
            else
            {
                LinesCount = -1;
            }
        }
    }
}
