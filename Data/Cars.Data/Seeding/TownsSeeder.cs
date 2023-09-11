namespace Cars.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Cars.Data.Models;

	public class TownsSeeder : ISeeder
	{
		
		public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
		{
			string townsAsString = "Sofia\r\nPlovdiv\r\nVarna\r\nBurgas\r\nRuse\r\nStara Zagora\r\nPleven\r\nSliven\r\nDobrich\r\nShumen\r\nPernik\r\nHaskovo\r\nBlagoevgrad\r\nYambol\r\nVeliko Tarnovo\r\nPazardzhik\r\nVratsa\r\nAsenovgrad\r\nGabrovo\r\nKazanluk\r\nKardzhali\r\nMontana\r\nKyustendil\r\nVidin\r\nTargovishte\r\nDimitrovgrad\r\nRazgrad\r\nLovech\r\nSilistra\r\nDupnitsa\r\nPetrich\r\nGorna Oryahovitsa\r\nSmolyan\r\nSamokov\r\nSandanski\r\nVelingrad\r\nSevlievo\r\nLom\r\nKarlovo\r\nVelingrad\r\nNova Zagora\r\nTroyan\r\nAytos\r\nBotevgrad\r\nGotse Delchev\r\nPeshtera\r\nHarmanli\r\nKarnobat\r\nSvilengrad\r\nPanagyurishte\r\nChirpan\r\nPopovo\r\nRakovski\r\nRadomir\r\nNovi Iskar\r\nKozloduy\r\nParvomay\r\nBerkovitsa\r\nCherven Bryag\r\nPomorie\r\nIhtiman\r\nRadnevo\r\nProvadiya\r\nNovi Pazar\r\nRazlog\r\nByala Slatina\r\nNesebar\r\nBalchik\r\nKostinbrod\r\nStamboliyski\r\nKavarna\r\nKnezha\r\nPavlikeni\r\nMezdra\r\nEtropole\r\nLevski\r\nTeteven\r\nElhovo\r\nBankya\r\nTryavna\r\nLukovit\r\nTutrakan\r\nSredets\r\nSopot\r\nByala\r\nVeliki Preslav\r\nIsperih\r\nBelene\r\nOmurtag\r\nBansko\r\nKrichim\r\nGalabovo\r\nDevnya\r\nSeptemvri\r\nRakitovo\r\nLyaskovets\r\nSvoge\r\nAksakovo\r\nKubrat\r\nDryanovo\r\nBeloslav\r\nPirdop\r\nLyubimets\r\nMomchilgrad\r\nSlivnitsa\r\nHisarya\r\nZlatograd\r\nKostenets\r\nDevin\r\nGeneral Toshevo\r\nSimeonovgrad\r\nSimitli\r\nElin Pelin\r\nDolni Chiflik\r\nTervel\r\nDulovo\r\nVarshets\r\nKotel\r\nMadan\r\nStraldzha\r\nSaedinenie\r\nBobov Dol\r\nTsarevo\r\nKuklen\r\nTvarditsa\r\nYakoruda\r\nElena\r\nTopolovgrad\r\nBozhurishte\r\nChepelare\r\nOryahovo\r\nSozopol\r\nBelogradchik\r\nPerushtitsa\r\nZlatitsa\r\nStrazhitsa\r\nKrumovgrad\r\nKameno\r\nDalgopol\r\nVetovo\r\nSuvorovo\r\nDolni Dabnik\r\nDolna Banya\r\nPravets\r\nNedelino\r\nPolski Trambesh\r\nTrastenik\r\nBratsigovo\r\nKoynare\r\nGodech\r\nSlavyanovo\r\nDve Mogili\r\nKostandovo\r\nDebelets\r\nStrelcha\r\nSapareva Banya\r\nIgnatievo\r\nSmyadovo\r\nBreznik\r\nSveti Vlas\r\nNikopol\r\nShivachevo\r\nBelovo\r\nTsar Kaloyan\r\nIvaylovgrad\r\nValchedram\r\nMarten\r\nGlodzhevo\r\nSarnitsa\r\nLetnitsa\r\nVarbitsa\r\nIskar\r\nArdino\r\nShabla\r\nRudozem\r\nVetren\r\nKresna\r\nBanya\r\nBatak\r\nMaglizh\r\nValchi Dol\r\nGulyantsi\r\nDragoman\r\nZavet\r\nKran\r\nMiziya\r\nPrimorsko\r\nSungurlare\r\nDolna Mitropoliya\r\nKrivodol\r\nKula\r\nKalofer\r\nSlivo Pole\r\nKaspichan\r\nApriltsi\r\nBelitsa\r\nRoman\r\nDzhebel\r\nDolna Oryahovitsa\r\nBuhovo\r\nGurkovo\r\nPavel Banya\r\nNikolaevo\r\nYablanitsa\r\nKableshkovo\r\nOpaka\r\nRila\r\nUgarchin\r\nDunavtsi\r\nDobrinishte\r\nHadzhidimovo\r\nBregovo\r\nByala Cherkva\r\nZlataritsa\r\nKocherinovo\r\nDospat\r\nTran\r\nSadovo\r\nLaki\r\nKoprivshtitsa\r\nMalko Tarnovo\r\nLoznitsa\r\nObzor\r\nKilifarevo\r\nBorovo\r\nBatanovtsi\r\nChernomorets\r\nAheloy\r\nByala\r\nPordim\r\nSuhindol\r\nMerichleri\r\nGlavinitsa\r\nChiprovtsi\r\nKermen\r\nBrezovo\r\nPlachkovtsi\r\nZemen\r\nBalgarovo\r\nAlfatar\r\nBoychinovtsi\r\nGramada\r\nSenovo\r\nMomin Prohod\r\nKaolinovo\r\nShipka\r\nAntonovo\r\nAhtopol\r\nBoboshevo\r\nBolyarovo\r\nBrusartsi\r\nKlisura\r\nDimovo\r\nKiten\r\nPliska\r\nMadzharovo\r\nMelnik";
			List<string> towns = townsAsString.Split("\r\n").ToList();

			foreach (var town in towns)
			{
				await dbContext.Towns.AddAsync(new Town { Name = town });

			}
			await dbContext.SaveChangesAsync();
		}
	}
}
