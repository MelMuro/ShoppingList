using ShoppingList.Extensions;

namespace ShoppingList.Models
{
    public class Enums
    {
        public enum Unit 
        {
            gr,
            ml,
            taza,
            pieza,
            cucharada,
            cucharadita,
            scoop
        }

        public enum Ingredient
        {
            [StringValue("aceite de canola")]
            aceiteDeCanola,
            [StringValue("aceite de coco")]
            aceiteDeCoco,
            [StringValue("aceite de maiz")]
            aceiteDeMaiz,
            [StringValue("aceite de olvia")]
            aceiteDeOliva,
            [StringValue("aceitunas negras")]
            aceitunasNegras,
            [StringValue("acelga cruda")]
            acelgaCruda,
            [StringValue("acelga picada cocida")]
            acelgaPicadaCocida,
            [StringValue("aguacate")]
            aguacate,
            [StringValue("alfalfa")]
            alfalfa,
            [StringValue("almeja fresca")]
            almejaFresca,
            [StringValue("almendra pieza")]
            almendraPieza,
            [StringValue("amaranto tostado")]
            amarantoTostado,
            [StringValue("apio")]
            apio,
            [StringValue("arandano")]
            arandano,
            [StringValue("arroz")]
            arroz,
            [StringValue("arroz cocido")]
            arrozCocido,
            [StringValue("atun en aceite")]
            atunEnAceite,
            [StringValue("atun en agua")]
            atunEnAgua,
            [StringValue("atun fresco")]
            atunFresco,
            [StringValue("avena")]
            avena,
            [StringValue("azucar de mesa")]
            azucarDeMesa,
            [StringValue("azucar mascabado")]
            azucarMascabado,
            [StringValue("berries")]
            berries,
            [StringValue("bistec de res")]
            bistecDeRes,
            [StringValue("brocoli")]
            brocoli,
            [StringValue("cacahuates")]
            cacahuates,
            [StringValue("calabaza")]
            calabaza,
            [StringValue("camaron")]
            camaron,
            [StringValue("camote")]
            camote,
            [StringValue("canela")]
            canela,
            [StringValue("carne de cerdo")]
            carneDeCerdo,
            [StringValue("carne de res")]
            carneDeRes,
            [StringValue("carne deshebrada")]
            carneDeshebrada,
            [StringValue("carne molida")]
            carneMolida,
            [StringValue("carne promedio")]
            carnePromedio,
            [StringValue("cebada")]
            cebada,
            [StringValue("cebolla")]
            cebolla,
            [StringValue("champiñon")]
            champiñon,
            [StringValue("cheerios")]
            cheerios,
            [StringValue("chia")]
            chia,
            [StringValue("chicharo")]
            chicharo,
            [StringValue("chile chipotle")]
            chileChipotle,
            [StringValue("chile colorado")]
            chileColorado,
            [StringValue("chile jalapeño")]
            chileJalapeño,
            [StringValue("chile morron")]
            chileMorron,
            [StringValue("chile verde")]
            chileVerde,
            [StringValue("chocolate turin sin azucar")]
            chocolateTurinSinAzucar,
            [StringValue("chuleta ahumada")]
            chuletaAhumada,
            [StringValue("cilantro")]
            cilantro,
            [StringValue("ciruela")]
            ciruela,
            [StringValue("clamato")]
            clamato,
            [StringValue("claras de huevo")]
            clarasDeHuevo,
            [StringValue("cocoa")]
            cocoa,
            [StringValue("col")]
            col,
            [StringValue("col morada")]
            colMorada,
            [StringValue("crema de cacahuate")]
            cremaDeCacahuate,
            [StringValue("datil")]
            datil,
            [StringValue("durazno amarillo")]
            duraznoAmarillo,
            [StringValue("ejote")]
            ejote,
            [StringValue("esparrago")]
            esparrago,
            [StringValue("espinaca")]
            espinaca,
            [StringValue("fresa")]
            fresa,
            [StringValue("frijol")]
            frijol,
            [StringValue("galletas habaneras")]
            galletasHabaneras,
            [StringValue("galletas marias")]
            galletasMarias,
            [StringValue("garbanzo cocido")]
            garbanzoCocido,
            [StringValue("gelatina light")]
            gelatinaLight,
            [StringValue("granola sin azucar")]
            granolaSinAzucar,
            [StringValue("guayaba")]
            guayaba,
            [StringValue("harina de almendra")]
            harinaDeAlmendra,
            [StringValue("higo")]
            higo,
            [StringValue("huevo")]
            huevo,
            [StringValue("hummus")]
            hummus,
            [StringValue("jamon de pavo")]
            jamonDePavo,
            [StringValue("jamon de pechuga de pavo")]
            jamonDePechugaDePavo,
            [StringValue("jitomate")]
            jitomate,
            [StringValue("kiwi")]
            kiwi,
            [StringValue("leche de almendra")]
            lecheDeAlmendra,
            [StringValue("leche de soya")]
            lecheDeSoya,
            [StringValue("leche descremada")]
            lecheDescremada,
            [StringValue("leche light")]
            lecheLight,
            [StringValue("leche semidescremada")]
            lecheSemidescremada,
            [StringValue("lechuga")]
            lechuga,
            [StringValue("lentejas cocidas")]
            lentejasCocidas,
            [StringValue("limon")]
            limon,
            [StringValue("machaca")]
            machaca,
            [StringValue("mandarina")]
            mandarina,
            [StringValue("mango")]
            mango,
            [StringValue("mantequilla de mani")]
            mantequillaDeMani,
            [StringValue("mantequilla")]
            mantequilla,
            [StringValue("manzana")]
            manzana,
            [StringValue("manzana roja")]
            manzanaRoja,
            [StringValue("manzana verde")]
            manzanaVerde,
            [StringValue("mayonesa")]
            mayonesa,
            [StringValue("media crema")]
            mediaCrema,
            [StringValue("melon picado")]
            melonPicado,
            [StringValue("mermelada sin azucar")]
            mermeladaSinAzucar,
            [StringValue("miel")]
            miel,
            [StringValue("moras")]
            moras,
            [StringValue("mostaza")]
            mostaza,
            [StringValue("naranja")]
            naranja,
            [StringValue("nieve sin azucar")]
            nieveSinAzucar,
            [StringValue("nopal cocido")]
            nopalCocido,
            [StringValue("nueces")]
            nueces,
            [StringValue("nutella")]
            nutella,
            [StringValue("pan birote")]
            panBirote,
            [StringValue("pan integral")]
            panIntegral,
            [StringValue("pan pita")]
            panPita,
            [StringValue("pan sin azucar")]
            panSinAzucar,
            [StringValue("papa")]
            papa,
            [StringValue("papaya")]
            papaya,
            [StringValue("papel de arroz")]
            papelDeArroz,
            [StringValue("pasta")]
            pasta,
            [StringValue("pavo")]
            pavo,
            [StringValue("pavo molido")]
            pavoMolido,
            [StringValue("pechuga de pollo")]
            pechugaDePollo,
            [StringValue("peperoni")]
            peperoni,
            [StringValue("pepino")]
            pepino,
            [StringValue("pepinillo")]
            pepinillo,
            [StringValue("pera")]
            pera,
            [StringValue("pescado")]
            pescado,
            [StringValue("pierna de pollo")]
            piernaDePollo,
            [StringValue("pimiento")]
            pimiento,
            [StringValue("pimiento amarillo")]
            pimientoAmarillo,
            [StringValue("pimiento rojo")]
            pimientoRojo,
            [StringValue("pimiento verde")]
            pimientoVerde,
            [StringValue("piña")]
            piña,
            [StringValue("platano")]
            platano,
            [StringValue("pollo desmenuzado")]
            polloDesmenuzado,
            [StringValue("portobelo")]
            portobelo,
            [StringValue("proteina")]
            proteina,
            [StringValue("queso cottage")]
            quesoCottage,
            [StringValue("queso fresco")]
            quesoFresco,
            [StringValue("queso panela")]
            quesoPanela,
            [StringValue("queso oaxaca")]
            quesoOaxaca,
            [StringValue("quinoa")]
            quinoa,
            [StringValue("rabano")]
            rabano,
            [StringValue("repollo")]
            repollo,
            [StringValue("rice cake")]
            riceCake,
            [StringValue("salmon")]
            salmon,
            [StringValue("salmon ahumado")]
            salmonAhumado,
            [StringValue("salsa buffalo")]
            salsaBuffalo,
            [StringValue("salsa pato")]
            salsaPato,
            [StringValue("sandia")]
            sandia,
            [StringValue("splenda")]
            splenda,
            [StringValue("stevia")]
            stevia,
            [StringValue("tiritas horneadas")]
            tiritasHorneadas,
            [StringValue("tiritas de tortilla")]
            tiritasDeTortilla,
            [StringValue("tocino de pavo")]
            tocinoDePavo,
            [StringValue("tomate")]
            tomate,
            [StringValue("toronja")]
            toronja,
            [StringValue("tortillas de maiz")]
            tortillasDeMaiz,
            [StringValue("tostadas horneadas")]
            tostadasHorneadas,
            [StringValue("uvas")]
            uvas,
            [StringValue("vainilla")]
            vainilla,
            [StringValue("vinagreta")]
            vinagreta,
            [StringValue("yogurt griego sin azucar")]
            yogurtGriegoSinAzucar,
            [StringValue("yogurt natural sin azucar")]
            yogurtNaturalSinAzucar,
            [StringValue("zanahoria")]
            zanahoria
        }

    }
}