using Microsoft.EntityFrameworkCore.Migrations;

namespace PE3.Migrations
{
    public partial class ClassRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "Id", "AmountOfPupils", "TeacherId" },
                values: new object[] { 1L, 0, 1L });

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "Id", "AmountOfPupils", "TeacherId" },
                values: new object[] { 2L, 0, 2L });

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "Id", "AmountOfPupils", "TeacherId" },
                values: new object[] { 3L, 10, 3L });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "Answer", "ClassRoomId", "Level", "Question" },
                values: new object[,]
                {
                    { 1L, "", 1L, 1, "" },
                    { 29L, "870", 3L, 3, "10 x 87 =" },
                    { 30L, "160", 3L, 3, "8 x 20 =" },
                    { 31L, "10", 3L, 3, "1000 : 100 =" },
                    { 32L, "630", 3L, 3, "9 x 70 =" },
                    { 33L, "5", 3L, 4, "Wat is de rest bij de deling 285:8?" },
                    { 34L, "2", 3L, 4, "Wat is de rest bij de deling 849:7?" },
                    { 35L, "280", 3L, 4, "70 x 4 =" },
                    { 36L, "50", 3L, 4, "450 : 9 =" },
                    { 37L, "72", 3L, 4, "Hoeveel is 12 x 6?" },
                    { 38L, "70", 3L, 4, "280 : 4 =" },
                    { 28L, "104", 3L, 3, "Zoek het verschil tussen 1000 en 896." },
                    { 39L, "836", 3L, 4, "De termen zijn 238 en 598. Wat is de som?" },
                    { 41L, "810", 3L, 4, "90 x 9 =" },
                    { 42L, "200", 3L, 4, "5 x 40" },
                    { 43L, "", 3L, 5, "In circus Pipo treden elke week enkele dieren op. De directeur van het circus heeft 4 boxen met telkens 3 slangen, 3 stallen met telkens 1 paard, 2 wagons met telkens 2 kamelen, 5 houten boxen met telkens 3 duiven, 6 kooien met telkens 4 konijnen en 3 hokken met telkens 1 olifant. Hoeveel dieren telt het circus Pipo?" },
                    { 44L, "192", 3L, 5, "Vorige maand kwamen er 768 bezoekers naar het circus. Circus Pipo was die maand vier weken open. Iedere week kwamen er evenveel bezoekers. Hoeveel bezoekers waren dit per week?" },
                    { 45L, "112", 3L, 5, "448 : 4 =" },
                    { 46L, "0", 3L, 5, "800 x 0 =" },
                    { 47L, "6", 3L, 5, "420 : 70 =" },
                    { 48L, "279", 3L, 5, "Hoeveel is 565 - 286?" },
                    { 49L, "828", 3L, 5, "207 x 4 =" },
                    { 50L, "80", 3L, 5, "480 : 6" },
                    { 40L, "300", 3L, 4, "60 x 5 =" },
                    { 27L, "500", 3L, 3, "1000 : 2 =" },
                    { 26L, "243", 3L, 3, "Trek 208 af van 451." },
                    { 25L, "9", 3L, 3, "180 : 20 =" },
                    { 2L, "", 2L, 1, "" },
                    { 3L, "273", 3L, 1, "De dierentuin koopt een viertal nieuwe vissoorten voor in het grote aquarium. Ze kopen 123 goudvissen, 18 kogelvissen, 55 maanvissen en 77 koperzalmen. Hoeveel vissen kocht de dierentuin in totaal?" },
                    { 4L, "728", 3L, 1, "In de dierentuin wordt er ook heel wat voedsel voor de dieren aangekocht. Zo werd er deze week 275kg vlees voor de leeuwen, 148kg vogelzaad en 305kg noten geleverd. Hoeveel kg voedsel werd in totaal geleverd?" },
                    { 5L, "230", 3L, 1, "Hoeveel is 10 x 23?" },
                    { 6L, "298", 3L, 1, "900 min 702 is?" },
                    { 7L, "89", 3L, 1, "Hoeveel is 130 - 41?" },
                    { 8L, "10", 3L, 1, "100 : 10 =" },
                    { 9L, "900", 3L, 1, "Hoeveel is 100 x 9?" },
                    { 10L, "748", 3L, 1, "429 plus 319 is?" },
                    { 11L, "500", 3L, 1, "10 x 50 =" },
                    { 12L, "0", 3L, 1, "0 x 0 =" },
                    { 13L, "56", 3L, 2, "De directeur van een school betaalt een uitstap: voor het vierde leerjaar betaalt hij 243 euro en voor het derde leerjaar betaalt hij 187 euro. Hoeveel kost de uitstap van het derde leerjaar minder dan die van het vierde leerjaar?" },
                    { 14L, "1", 3L, 2, "50 : 50 =" },
                    { 15L, "100", 3L, 2, "1000 : 10 =" },
                    { 16L, "640", 3L, 2, "Hoeveel is 80 x 8?" },
                    { 17L, "6", 3L, 2, "300 : 50 =" },
                    { 18L, "45", 3L, 2, "450 : 10 =" },
                    { 19L, "901", 3L, 2, "Hoeveel is 502 + 399?" },
                    { 20L, "110", 3L, 2, "11 x 10 = " },
                    { 21L, "899", 3L, 2, "Bereken de som van 576 en 249 en 74." },
                    { 22L, "560", 3L, 2, "56 x 10" },
                    { 23L, "364", 3L, 3, "Het derde en vierde leerjaar van Basisschool 'De Springplank' uit Brugge gaan met de bus op uitstap naar de Zoo van Antwerpen. Het derde leerjaar gaat op maandag naar de dierentuin en het vierde leerjaar gaat op dinsdag. De afstand van Brugge naar Antwerpen is 91km. Hoeveel km moet de bus in het totaal afleggen om het derde en het vierde leerjaar 's ochtends naar de dierentuin en 's avonds terug naar de school te brengen?" },
                    { 24L, "70", 3L, 3, "Stephan de olifant is een reusachtig beest en heeft per week veel voedsel nodig. Stephan eet 210kg voedsel per dag. De opzichter geeft Stephan drie keer per dag evenveel eten. Hoeveel kg voedsel is dit per keer?" },
                    { 51L, "508", 3L, 5, "127 x 4 =" },
                    { 52L, "231", 3L, 5, "693 : 3 =" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}
