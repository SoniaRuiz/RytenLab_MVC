﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using RytenLab_Web.Models;
using RytenLab_Web.Repositories;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace RytenLab_Web.Controllers
{
    /// <summary>
    /// This controller sets the main operations of RytenLab web
    /// </summary>
    public class RytenLabController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;

        public RytenLabController(IHostingEnvironment environment)
        {
            _hostingEnvironment = environment;
        }


        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Controller method for the main page
        /// </summary>
        /// <returns>Returns 'About' view</returns>
        public IActionResult About()
        {
            return View();
        }
        /// <summary>
        /// Controller method for 'Team' Page
        /// It takes the data from an xml file called team.xml.
        /// </summary>
        /// <returns>
        /// If everything is ok: Returns 'Team' view.
        /// If an error occurs: returns 'Error' view
        /// </returns>
        public IActionResult Team()
        {
            try
            {
                Team teamMembers = new Team();

                var path = Path.Combine(_hostingEnvironment.WebRootPath, "xml/team.xml");
                //Load the XML file in XmlDocument.
                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                //Loop through the selected Nodes.
                foreach (XmlNode node in doc.SelectNodes("/TeamMembers/Person"))
                {
                    //Fetch the Node values and assign it to Model.
                    teamMembers.TeamMembers.Add(new Person
                    {
                        ID = int.Parse(node["ID"].InnerText),
                        Name = node["Name"].InnerText,
                        Title = node["Title"].InnerText,
                        Job = node["Job"].InnerText,
                        Email = node["Email"].InnerText,
                        ResearchInterest = node["ResearchInterest"].InnerText,
                        Biography = node["Biography"].InnerText,
                        ImagePath = node["ImagePath"].InnerText,
                        GitHub = node["GitHub"].InnerText,
                        ResearchGate = node["ResearchGate"].InnerText,
                        CurrentMember = node["CurrentMember"].InnerText
                    });
                }

                return View(teamMembers);
            }
            catch (Exception e)
            {
                ErrorViewModel errorModel = new ErrorViewModel
                {
                    Message = e.Message
                };
                return View("Error", errorModel);
            }
        }
        /// <summary>
        /// Controller method for 'Data' page.
        /// </summary>
        /// <returns>Returns 'Data' view.</returns>
        public IActionResult Data()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        /// <summary>
        /// Controller method for 'Tools' page.
        /// </summary>
        /// <returns>Returns 'Tools' view.</returns>
        public IActionResult Tools()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        ///// <summary>
        ///// Controller method for 'Publications' page.
        ///// </summary>
        ///// <returns>
        ///// If everything is ok: Returns 'Publications' view.
        ///// If an error occurs: returns 'Error' view
        ///// </returns>
        //public IActionResult Publications()
        //{
        //    try
        //    {
        //        Person publicationsPerson = new Person();
        //        PublicationRepository publications = new PublicationRepository();

        //        //NCBI publications ID (from all team members)
        //        publicationsPerson.NCBIPublicationsID = "30328509,30225556,30089514,30066433,29930110,29365066,29127725,29289683,28899015,28764847,28602509,28575651,28403906,28391543,28137300,28098162,28097204,28076797,28010125,28004117,27899424,27694991,27584932,27500074,27073233,26968196,26912063,26707700,26468326,26085604,25983243,25970246,25799108,25620700,25607358,25568836,25439728,25174004,24862029,24503276,24399358,24336208,24264146,24259043,24241535,24198383,24175058,24014518,23967090,23889843,23855984,23435227,23424103,23360175,23200863,23177596,22778642,22723018,22681703,22504417,22433082,21944779,21863007,21848658,21799870,20849322,20842366,19909261,19734301,18005209,17941929,15911103,15231720,15484912,14517997,12135987";
        //        publicationsPerson = publications.GetPublicationsDataNCBI(publicationsPerson);

        //        return View(publicationsPerson);
        //    }
        //    catch (Exception e)
        //    {
        //        ErrorViewModel errorModel = new ErrorViewModel();
        //        errorModel.Message = e.Message;
        //        return View("Error", errorModel);
        //    }
        //}
        /// <summary>
        /// Controller method for 'Contact' page.
        /// </summary>
        /// <returns> Returns 'Contact' view. </returns>
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        /// <summary>
        /// Controller method for 'MemberInfo' page
        /// </summary>
        /// <param name="person">Team member info</param>
        /// <returns>'MemberInfo' view</returns>
        [HttpPost]
        public IActionResult MemberInfo(Person person)
        {
            try
            {
                //PublicationRepository publications = new PublicationRepository();
                //person = publications.GetPublicationsDataNCBI(person);
                //person = publications.GetPublicationsDataCrossRef(person);

                return View(person);
            }
            catch(Exception e)
            {
                ErrorViewModel errorModel = new ErrorViewModel
                {
                    Message = e.Message
                };
                return View("Error", errorModel);
            }
        }
        /// <summary>
        /// Controller method for returning 'MemberInfo' page
        /// Is requesting using GET protocol.
        /// </summary>
        /// <param name="person">Team member info</param>
        /// <returns>'MemberInfo' view</returns>
        [HttpGet]
        [ActionName("MemberInfo")]
        public ActionResult MemberInfoGet(Person person)
        {
            try
            {
                string memberName = string.Empty;

                switch (person.Id)
                {
                    case "8774A_!52101":
                        memberName = "Mina Ryten";
                        break;  // Always break each case
                    case "BP98-F74160":
                        memberName = "Juan A. Botía";
                        break;
                    case "1A_P04986":
                        memberName = "Juan A. Sanchez";
                        break;
                    case "2548LOP641":
                        memberName = "Karishma D'Sa";
                        break;
                    case "91AA_B35843":
                        memberName = "Sebastian Guelfi";
                        break;
                    case "103698KFT714":
                        memberName = "Regina H. Reynolds";
                        break;
                    case "103PO8741457":
                        memberName = "David Zhang";
                        break;
                    case "LO96_F34158":
                        memberName = "Sonia García Ruiz";
                        break;
                    case "189635LLDP42":
                        memberName = "Zhongbo Chen";
                        break;
                    case "3DD_P9652844":
                        memberName = "Siddharth Sethi";
                        break;
                    case "1_FON05125800":
                        memberName = "Aine Fairbrother-Browne";
                        break;
                    //case "85_RR4347H20":
                    //    memberName = "Fran Kiernan";
                    //    break;
                };

                var path = Path.Combine(_hostingEnvironment.WebRootPath, "xml/team.xml");
                //Load the XML file in XmlDocument.
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                //Loop through the selected Nodes.
                foreach (XmlNode node in doc.SelectNodes("/TeamMembers/Person"))
                {
                    if(node["Name"].InnerText == memberName)
                    {
                        person.ID = int.Parse(node["ID"].InnerText);
                        person.Name = node["Name"].InnerText;
                        person.Title = node["Title"].InnerText;
                        person.Job = node["Job"].InnerText;
                        person.Email = node["Email"].InnerText;
                        person.ResearchInterest = node["ResearchInterest"].InnerText;
                        person.Biography = node["Biography"].InnerText;
                        person.ImagePath = node["ImagePath"].InnerText;
                        person.GitHub = node["GitHub"].InnerText;
                        person.ResearchGate = node["ResearchGate"].InnerText;
                        person.CurrentMember = node["CurrentMember"].InnerText;
                        break;
                    }
                }
                return View(person);
            }
            catch (Exception e)
            {
                ErrorViewModel errorModel = new ErrorViewModel
                {
                    Message = e.Message
                };
                return View("Error", errorModel);
            }
        }
        /// <summary>
        /// Controller method for 'Privacy' page
        /// </summary>
        /// <returns>Returns 'Privacy' view</returns>
        public IActionResult Privacy()
        {
            //TODO: set this 'privacy' page
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { Message = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
