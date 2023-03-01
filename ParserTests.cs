using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrayForOffer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrayForOffer.Tests
{
    [TestClass()]
    public class ParserTests
    {
        [TestMethod()]
        public void ParseStringArrayTest()
        {
            var expect = new string[][]{
                new string[]{"ток", "кот", "Кто" },
                new string[]{"рост","торс" },
                new string[]{"фывап"},
                new string[]{"рок"}
            };
            var data = new string[] { "ток", "рост", "кот", "торс", "Кто", "фывап", "рок" };
            var result = Parser.ParseStringArray(data);
            Enumerable.SequenceEqual(expect, result);
        }
        [TestMethod()]
        public void ParseStringArrayTest2()
        {
            var expect = new string[][]{};
            var data = new string[] {};
            var result = Parser.ParseStringArray(data);
            Enumerable.SequenceEqual(expect, result);
        }
        [TestMethod()]
        public void ParseStringArrayTest3()
        {
            var expect = new string[][]{};
            var result = Parser.ParseStringArray(null);
            Enumerable.SequenceEqual(expect, result);
        }
        [TestMethod()]
        public void ParseStringArrayTest4()
        {
            var expect = new string[][]{
                new string[]{"floor"},
                new string[]{"roof","rofo"},
                new string[]{"roller"},
                new string[]{"guide","idegu"}
            };
            var data = new string[] {"floor","roof","rofo","roller","guide","idegu"};
            var result = Parser.ParseStringArray(data);
            Enumerable.SequenceEqual(expect, result);
        }
        [TestMethod()]
        public void ParseStringArrayTest5()
        {
            var expect = new string[][]{
                new string[]{"gucci"},
                new string[]{"prado",},
                new string[]{"lui"},
                new string[]{ "на мне только fendi hoodie"}
            };
            var data = new string[] {"gucci","prado","lui","на мне только fendi hoodie"};
            var result = Parser.ParseStringArray(data);
            Enumerable.SequenceEqual(expect, result);
        }
    }
}