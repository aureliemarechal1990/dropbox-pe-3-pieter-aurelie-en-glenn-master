using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PE3.Entities;

namespace PE3.Data
{
	public class QuestionSeeder
	{
		public static void Seed(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Questions>().HasData(
				new Questions {QuestionId = 1, Question = "", Answer = "", Level = 1, ClassRoomId = 1},
				new Questions {QuestionId = 2, Question = "", Answer = "", Level = 1, ClassRoomId = 2},
				new Questions {QuestionId = 3, Question = "De dierentuin koopt een viertal nieuwe vissoorten voor in het grote aquarium. Ze kopen 123 goudvissen, 18 kogelvissen, 55 maanvissen en 77 koperzalmen. Hoeveel vissen kocht de dierentuin in totaal?", Answer = "273", Level = 1, ClassRoomId = 3},
				new Questions {QuestionId = 4, Question = "In de dierentuin wordt er ook heel wat voedsel voor de dieren aangekocht. Zo werd er deze week 275kg vlees voor de leeuwen, 148kg vogelzaad en 305kg noten geleverd. Hoeveel kg voedsel werd in totaal geleverd?", Answer = "728", Level = 1, ClassRoomId = 3},
				new Questions {QuestionId = 5, Question = "Hoeveel is 10 x 23?", Answer = "230", Level = 1, ClassRoomId = 3},
				new Questions {QuestionId = 6, Question = "900 min 702 is?", Answer = "298", Level = 1, ClassRoomId = 3},
				new Questions {QuestionId = 7, Question = "Hoeveel is 130 - 41?", Answer = "89", Level = 1, ClassRoomId = 3},
				new Questions {QuestionId = 8, Question = "100 : 10 =", Answer = "10", Level = 1, ClassRoomId = 3},
				new Questions {QuestionId = 9, Question = "Hoeveel is 100 x 9?", Answer = "900", Level = 1, ClassRoomId = 3},
				new Questions {QuestionId = 10, Question = "429 plus 319 is?", Answer = "748", Level = 1, ClassRoomId = 3},
				new Questions {QuestionId = 11, Question = "10 x 50 =", Answer = "500", Level = 1, ClassRoomId = 3},
				new Questions {QuestionId = 12, Question = "0 x 0 =", Answer = "0", Level = 1, ClassRoomId = 3},
				new Questions {QuestionId = 13, Question = "De directeur van een school betaalt een uitstap: voor het vierde leerjaar betaalt hij 243 euro en voor het derde leerjaar betaalt hij 187 euro. Hoeveel kost de uitstap van het derde leerjaar minder dan die van het vierde leerjaar?", Answer = "56", Level = 2, ClassRoomId = 3},
				new Questions {QuestionId = 14, Question = "50 : 50 =", Answer = "1", Level = 2, ClassRoomId = 3},
				new Questions {QuestionId = 15, Question = "1000 : 10 =", Answer = "100", Level = 2, ClassRoomId = 3},
				new Questions {QuestionId = 16, Question = "Hoeveel is 80 x 8?", Answer = "640", Level = 2, ClassRoomId = 3},
				new Questions {QuestionId = 17, Question = "300 : 50 =", Answer = "6", Level = 2, ClassRoomId = 3},
				new Questions {QuestionId = 18, Question = "450 : 10 =", Answer = "45", Level = 2, ClassRoomId = 3},
				new Questions {QuestionId = 19, Question = "Hoeveel is 502 + 399?", Answer = "901", Level = 2, ClassRoomId = 3},
				new Questions {QuestionId = 20, Question = "11 x 10 = ", Answer = "110", Level = 2, ClassRoomId = 3},
				new Questions {QuestionId = 21, Question = "Bereken de som van 576 en 249 en 74.", Answer = "899", Level = 2, ClassRoomId = 3},
				new Questions {QuestionId = 22, Question = "56 x 10", Answer = "560", Level = 2, ClassRoomId = 3},
				new Questions {QuestionId = 23, Question = "Het derde en vierde leerjaar van Basisschool 'De Springplank' uit Brugge gaan met de bus op uitstap naar de Zoo van Antwerpen. Het derde leerjaar gaat op maandag naar de dierentuin en het vierde leerjaar gaat op dinsdag. De afstand van Brugge naar Antwerpen is 91km. Hoeveel km moet de bus in het totaal afleggen om het derde en het vierde leerjaar 's ochtends naar de dierentuin en 's avonds terug naar de school te brengen?", Answer = "364", Level = 3, ClassRoomId = 3},
				new Questions {QuestionId = 24, Question = "Stephan de olifant is een reusachtig beest en heeft per week veel voedsel nodig. Stephan eet 210kg voedsel per dag. De opzichter geeft Stephan drie keer per dag evenveel eten. Hoeveel kg voedsel is dit per keer?", Answer = "70", Level = 3, ClassRoomId = 3},
				new Questions {QuestionId = 25, Question = "180 : 20 =", Answer = "9", Level = 3, ClassRoomId = 3},
				new Questions {QuestionId = 26, Question = "Trek 208 af van 451.", Answer = "243", Level = 3, ClassRoomId = 3},
				new Questions {QuestionId = 27, Question = "1000 : 2 =", Answer = "500", Level = 3, ClassRoomId = 3},
				new Questions {QuestionId = 28, Question = "Zoek het verschil tussen 1000 en 896.", Answer = "104", Level = 3, ClassRoomId = 3},
				new Questions {QuestionId = 29, Question = "10 x 87 =", Answer = "870", Level = 3, ClassRoomId = 3},
				new Questions {QuestionId = 30, Question = "8 x 20 =", Answer = "160", Level = 3, ClassRoomId = 3},
				new Questions {QuestionId = 31, Question = "1000 : 100 =", Answer = "10", Level = 3, ClassRoomId = 3},
				new Questions {QuestionId = 32, Question = "9 x 70 =", Answer = "630", Level = 3, ClassRoomId = 3},
				new Questions {QuestionId = 33, Question = "Wat is de rest bij de deling 285:8?", Answer = "5", Level = 4, ClassRoomId = 3},
				new Questions {QuestionId = 34, Question = "Wat is de rest bij de deling 849:7?", Answer = "2", Level = 4, ClassRoomId = 3},
				new Questions {QuestionId = 35, Question = "70 x 4 =", Answer = "280", Level = 4, ClassRoomId = 3},
				new Questions {QuestionId = 36, Question = "450 : 9 =", Answer = "50", Level = 4, ClassRoomId = 3},
				new Questions {QuestionId = 37, Question = "Hoeveel is 12 x 6?", Answer = "72", Level = 4, ClassRoomId = 3},
				new Questions {QuestionId = 38, Question = "280 : 4 =", Answer = "70", Level = 4, ClassRoomId = 3},
				new Questions {QuestionId = 39, Question = "De termen zijn 238 en 598. Wat is de som?", Answer = "836", Level = 4, ClassRoomId = 3},
				new Questions {QuestionId = 40, Question = "60 x 5 =", Answer = "300", Level = 4, ClassRoomId = 3},
				new Questions {QuestionId = 41, Question = "90 x 9 =", Answer = "810", Level = 4, ClassRoomId = 3},
				new Questions {QuestionId = 42, Question = "5 x 40", Answer = "200", Level = 4, ClassRoomId = 3},
				new Questions {QuestionId = 43, Question = "In circus Pipo treden elke week enkele dieren op. De directeur van het circus heeft 4 boxen met telkens 3 slangen, 3 stallen met telkens 1 paard, 2 wagons met telkens 2 kamelen, 5 houten boxen met telkens 3 duiven, 6 kooien met telkens 4 konijnen en 3 hokken met telkens 1 olifant. Hoeveel dieren telt het circus Pipo?", Answer = "", Level = 5, ClassRoomId = 3},
				new Questions {QuestionId = 44, Question = "Vorige maand kwamen er 768 bezoekers naar het circus. Circus Pipo was die maand vier weken open. Iedere week kwamen er evenveel bezoekers. Hoeveel bezoekers waren dit per week?", Answer = "192", Level = 5, ClassRoomId = 3},
				new Questions {QuestionId = 45, Question = "448 : 4 =", Answer = "112", Level = 5, ClassRoomId = 3},
				new Questions {QuestionId = 46, Question = "800 x 0 =", Answer = "0", Level = 5, ClassRoomId = 3},
				new Questions {QuestionId = 47, Question = "420 : 70 =", Answer = "6", Level = 5, ClassRoomId = 3},
				new Questions {QuestionId = 48, Question = "Hoeveel is 565 - 286?", Answer = "279", Level = 5, ClassRoomId = 3},
				new Questions {QuestionId = 49, Question = "207 x 4 =", Answer = "828", Level = 5, ClassRoomId = 3},
				new Questions {QuestionId = 50, Question = "480 : 6", Answer = "80", Level = 5, ClassRoomId = 3},
				new Questions {QuestionId = 51, Question = "127 x 4 =", Answer = "508", Level = 5, ClassRoomId = 3},
				new Questions {QuestionId = 52, Question = "693 : 3 =", Answer = "231", Level = 5, ClassRoomId = 3});
		}
	}
}
