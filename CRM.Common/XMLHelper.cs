using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MingMing.Common
{
    public class XMLHelper
    {

        //XmlSerializer
        public static XMLHelper Instance { get; set; }
        static XMLHelper()
        {
            Instance = new XMLHelper();
        }

        private XMLHelper()
        {

        }

        /// <summary>
        /// 创建xml文件
        /// </summary>
        /// <param name="path"></param>
        /// <param name="fileName"></param>
        public void CreateXML(string path, string fileName)
        {
            if (File.Exists(Path.Combine(path, fileName)))
            {
                File.Delete(Path.Combine(path, fileName));
            }

            //if (!File.Exists(Path.Combine(path, fileName)))
            //{
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(dec);
            //根节点  
            XmlElement root = doc.CreateElement("Department");
            doc.AppendChild(root);
            doc.Save("Department.xml");
            //}
        }

        /// <summary>
        /// 写入xml数据
        /// </summary>
        /// <param name="teamList"></param>
        //public void WriteDatas(List<Team> teamList)
        //{
        //    XmlDocument xmlDocument = new XmlDocument();
        //    string path = Path.Combine(Application.StartupPath, "Department.xml");
        //    xmlDocument.Load(path);
        //    XmlNode root = xmlDocument.SelectSingleNode("Department");
        //    foreach (Team item in teamList)
        //    {
        //        XmlNode node = xmlDocument.CreateNode("element", "Data", "");
        //        //ID
        //        XmlElement idElement = xmlDocument.CreateElement("ID");
        //        idElement.InnerText = item.ID.ToString();
        //        node.AppendChild(idElement);

        //        //ParentID
        //        XmlElement parentIDElement = xmlDocument.CreateElement("ParentID");
        //        parentIDElement.InnerText = item.ParentID.ToString();
        //        node.AppendChild(parentIDElement);

        //        //销售小组
        //        XmlElement teamNameElement = xmlDocument.CreateElement("TeamName");
        //        teamNameElement.InnerText = item.TeamName;
        //        node.AppendChild(teamNameElement);

        //        //置业顾问
        //        XmlElement salerElement = xmlDocument.CreateElement("Saler");
        //        salerElement.InnerText = item.Saler;
        //        node.AppendChild(salerElement);

        //        root.AppendChild(node);
        //    }
        //    xmlDocument.Save(path);
        //}

        /// <summary>
        /// 读取xml
        /// </summary>
        /// <returns></returns>
        //public List<Team> ReadXMLData()
        //{
        //    string path = Path.Combine(Application.StartupPath, "Department.xml");
        //    if (!File.Exists(Path.Combine(path)))
        //    {
        //        return null;
        //    }

        //    List<Team> teamList = new List<Team>();

        //    XDocument doc = XDocument.Load(path);
        //    IEnumerable<XElement> node = doc.Element("Department").Elements("Data");

        //    foreach (XElement element in node)
        //    {
        //        Team team = new Team();
        //        team.ID = int.Parse(element.Elements("ID").FirstOrDefault().Value);
        //        team.ParentID = int.Parse(element.Elements("ParentID").FirstOrDefault().Value);
        //        team.TeamName = element.Elements("TeamName").FirstOrDefault().Value;
        //        team.Saler = element.Elements("Saler").FirstOrDefault().Value;
        //        teamList.Add(team);

        //    }
        //    return teamList;

        //}

        ///// <summary>
        ///// 插入
        ///// </summary>
        ///// <param name="team"></param>
        ///// <returns></returns>
        //public int Insert(Team team)
        //{
        //    string path = Path.Combine(Application.StartupPath, "Department.xml");
        //    XDocument doc = XDocument.Load(path);
        //    XElement node = doc.Element("Department").Elements().Where(p => string.IsNullOrEmpty(p.Element("Saler").Value)).First();

        //    //XElement node = rootNode.Element("Department").Elements("Data").Where(p =>string.IsNullOrEmpty( p.Element("Saler").Value)).First();
        //    XElement element = new XElement("Data",
        //          new XElement("ID", team.ID),
        //          new XElement("ParentID", team.ParentID),
        //          new XElement("TeamName", team.TeamName),
        //          new XElement("Saler", team.Saler)
        //         );
        //    node.AddBeforeSelf(element);
        //    doc.Save(path);
        //    return 1;
        //}

        //public Team GetXmlNodeByID(int id)
        //{
        //    string path = Path.Combine(Application.StartupPath, "Department.xml");
        //    XDocument doc = XDocument.Load(path);
        //    XElement element = doc.Element("Department").Elements("Data").Where(p => p.Element("ID").Value == id.ToString()).FirstOrDefault();
        //    Team team = new Team();
        //    team.ID = int.Parse(element.Elements("ID").First().Value);
        //    team.ParentID = int.Parse(element.Elements("ParentID").First().Value);
        //    team.TeamName = element.Elements("TeamName").First().Value;
        //    team.Saler = element.Elements("Saler").First().Value;
        //    return team;
        //}

        ///// <summary>
        ///// 修改
        ///// </summary>
        ///// <param name="team"></param>
        ///// <returns></returns>
        //public int AlterTeam(Team team)
        //{
        //    string path = Path.Combine(Application.StartupPath, "Department.xml");
        //    XDocument doc = XDocument.Load(path);

        //    IEnumerable<XElement> t = doc.Element("Department").Elements("Data").Where(p => p.Element("ID").Value == team.ID.ToString());

        //    XElement elementParentID = t.FirstOrDefault().Elements("ParentID").FirstOrDefault();
        //    elementParentID.Value = team.ParentID.ToString();

        //    XElement elementTeamName = t.FirstOrDefault().Elements("TeamName").FirstOrDefault();
        //    elementTeamName.Value = team.TeamName;

        //    XElement elementSaler = t.FirstOrDefault().Elements("Saler").FirstOrDefault();
        //    elementSaler.Value = team.Saler;

        //    doc.Save(path);
        //    return 1;
        //}

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteNode(int id)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Department.xml");
            XDocument doc = XDocument.Load(path);

            IEnumerable<XElement> t = doc.Element("Department").Elements("Data").Where(p => p.Element("ID").Value == id.ToString());
            t.Remove();

            doc.Save(path);
            return 1;
        }



        ///// <summary>
        ///// 获取部门节点
        ///// </summary>
        ///// <param name="teamName"></param>
        ///// <returns></returns>
        //public Team GetTeamByTeamName(string teamName)
        //{
        //    string path = Path.Combine(Application.StartupPath, "Department.xml");
        //    XDocument doc = XDocument.Load(path);

        //    XElement element = doc.Element("Department").Elements().Where(p => string.IsNullOrEmpty(p.Element("Saler").Value) && (p.Element("ParentID").Value == "0") && p.Element("TeamName").Value == teamName).First();
        //    Team team = new Team();
        //    team.ID = int.Parse(element.Elements("ID").First().Value);
        //    team.ParentID = int.Parse(element.Elements("ParentID").First().Value);
        //    team.TeamName = element.Elements("TeamName").First().Value;
        //    team.Saler = element.Elements("Saler").First().Value;
        //    return team;
        //}


        ///// <summary>
        ///// 节点后添加部门节点
        ///// </summary>
        ///// <param name="team"></param>
        ///// <returns></returns>
        //public int AddTeamNode(Team team)
        //{
        //    string path = Path.Combine(Application.StartupPath, "Department.xml");


        //    List<Team> teamList = new List<Team>();

        //    XDocument doc = XDocument.Load(path);
        //    IEnumerable<XElement> node = doc.Element("Department").Elements("Data");
        //    //List<int> idStrList = node.Select(p =>int.Parse( p.Element("ID").Value)).ToList();
        //    int maxID = node.Select(p => int.Parse(p.Element("ID").Value)).Max(p => p);
        //    team.ID = maxID + 1;

        //    XElement lastElement = node.Last();
        //    XElement element = new XElement("Data",
        //  new XElement("ID", team.ID),
        //  new XElement("ParentID", team.ParentID),
        //  new XElement("TeamName", team.TeamName),
        //  new XElement("Saler", team.Saler)
        // );
        //    lastElement.AddAfterSelf(element);
        //    doc.Save(path);

        //    return 1;
        //}

        /// <summary>
        /// 检查要添加的部门是否存在
        /// </summary>
        /// <param name="teamName"></param>
        /// <returns></returns>
        public bool CheckTeamNameExist(string teamName)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Department.xml");
            XDocument doc = XDocument.Load(path);

            IEnumerable<XElement> teamElement = doc.Element("Department").Elements().Where(p => string.IsNullOrEmpty(p.Element("Saler").Value) && (p.Element("ParentID").Value == "0") && p.Element("TeamName").Value == teamName);

            return teamElement.Count() > 0;
        }

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="id">部门节点ID</param>
        /// <returns></returns>
        public int DeleteTeamNode(string teamName)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Department.xml");
            XDocument doc = XDocument.Load(path);

            //XElement teamElement = doc.Element("Department").Elements().Where(p => string.IsNullOrEmpty(p.Element("Saler").Value) && (p.Element("ParentID").Value == "0") && p.Element("ID").Value == id.ToString()).First();
            //IEnumerable<XElement> salerElement = doc.Element("Department").Elements().Where(p => string.IsNullOrEmpty(p.Element("Saler").Value) && (p.Element("ParentID").Value == "0") && p.Element("ParentID").Value == id.ToString());

            IEnumerable<XElement> departmentElement = doc.Element("Department").Elements().Where(p => p.Element("TeamName").Value == teamName);
            departmentElement.Remove();
            doc.Save(path);

            return 1;
        }
    }
}
