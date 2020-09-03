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
            [StringValue("ajo")]
            ajo,
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
            [StringValue("bbq")]
            bbq,
            [StringValue("berries")]
            berries,
            [StringValue("betabel")]
            betabel,
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
            [StringValue("catsup")]
            catsup,
            [StringValue("cebada")]
            cebada,
            [StringValue("cebolla")]
            cebolla,
            [StringValue("cereal")]
            cereal,
            [StringValue("champiñon")]
            champiñon,
            [StringValue("chayote")]
            chayote,
            [StringValue("chamoy sin azucar")]
            chamoySinAzucar,
            [StringValue("chips de pita")]
            chipsDePita,
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
            [StringValue("chile serrano")]
            chileSerrano,
            [StringValue("chile quebrado")]
            chileQuebrado,
            [StringValue("chile guajillo")]
            chileGuajillo,
            [StringValue("chiltepines")]
            chiltepines,
            [StringValue("chocolate turin sin azucar")]
            chocolateTurinSinAzucar,
            [StringValue("chocolate")]
            chocolate,
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
            [StringValue("coco rallado")]
            cocoRallado,
            [StringValue("coliflor")]
            coliflor,
            [StringValue("crema de cacahuate")]
            cremaDeCacahuate,
            [StringValue("datil")]
            datil,
            [StringValue("durazno amarillo")]
            duraznoAmarillo,
            [StringValue("ejote")]
            ejote,
            [StringValue("elote")]
            elote,
            [StringValue("elotitos")]
            elotitos,
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
            [StringValue("garbanzo")]
            garbanzo,
            [StringValue("garbanzo cocido")]
            garbanzoCocido,
            [StringValue("gelatina light")]
            gelatinaLight,
            [StringValue("granola sin azucar")]
            granolaSinAzucar,
            [StringValue("grenetina")]
            grenetina,
            [StringValue("guayaba")]
            guayaba,
            [StringValue("harina de almendra")]
            harinaDeAlmendra,
            [StringValue("harina de avena")]
            harinaDeAvena,
            [StringValue("higo")]
            higo,
            [StringValue("hoja de arroz")]
            hojaDeArroz,
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
            [StringValue("jicama")]
            jicama,
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
            [StringValue("lentejas")]
            lentejas,
            [StringValue("lentejas cocidas")]
            lentejasCocidas,
            [StringValue("limon")]
            limon,
            [StringValue("lomo de cerdo")]
            lomoDeCerdo,
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
            [StringValue("matcha")]
            matcha,
            [StringValue("mayonesa")]
            mayonesa,
            [StringValue("media crema")]
            mediaCrema,
            [StringValue("melon picado")]
            melonPicado,
            [StringValue("mermelada")]
            mermelada,
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
            [StringValue("nopales")]
            nopales,
            [StringValue("nueces")]
            nueces,
            [StringValue("nuez de la india")]
            nuezDeLaIndia,
            [StringValue("nutella")]
            nutella,
            [StringValue("oblea")]
            oblea,
            [StringValue("oregano")]
            oregano,
            [StringValue("pan birote")]
            panBirote,
            [StringValue("pan integral")]
            panIntegral,
            [StringValue("pan pita")]
            panPita,
            [StringValue("pan sin azucar")]
            panSinAzucar,
            [StringValue("pan thins")]
            panThins,
            [StringValue("papa")]
            papa,
            [StringValue("papaya")]
            papaya,
            [StringValue("palomitas")]
            palomitas,
            [StringValue("papel de arroz")]
            papelDeArroz,
            [StringValue("pasta")]
            pasta,
            [StringValue("pasas")]
            pasas,
            [StringValue("carne de pavo")]
            pavo,
            [StringValue("pavo molido")]
            pavoMolido,
            [StringValue("pavo al pastor")]
            pavoAlPastor,
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
            [StringValue("pimienta")]
            pimienta,
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
            [StringValue("queso panela")]
            quesoPanela,
            [StringValue("queso oaxaca")]
            quesoOaxaca,
            [StringValue("queso vegano")]
            quesoVegano,
            [StringValue("quinoa")]
            quinoa,
            [StringValue("rabano")]
            rabano,
            [StringValue("ramen")]
            ramen,
            [StringValue("repollo")]
            repollo,
            [StringValue("repollo morado")]
            repolloMorado,
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
            [StringValue("salsa roja")]
            salsaRoja,
            [StringValue("salsa verde")]
            salsaVerde,
            [StringValue("sandia")]
            sandia,
            [StringValue("siracha")]
            siracha,
            [StringValue("splenda")]
            splenda,
            [StringValue("surimi")]
            surimi,
            [StringValue("stevia")]
            stevia,
            [StringValue("tajin")]
            tajin,
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
            [StringValue("tortilla de maiz")]
            tortillaDeMaiz,
            [StringValue("tortilla multigrano")]
            tortillaMultigrano,
            [StringValue("tortilla de nopal")]
            tortillaDeNopal,
            [StringValue("tostadas horneadas")]
            tostadasHorneadas,
            [StringValue("uva")]
            uva,
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