import scala.io._
import scala.util.matching.Regex
object TASK2 {

    val mainUrl = "https://www.cnn.com/"  // this is x as discussed in problem statement
    val linkRegex = "(?i)<a.+?href=\"(http.+?)\".*?>(.+?)</a>".r
    val imgRegex = "<?img.+?src=\"(.+?)\".*>".r
    val scriptRegex = "<?script.*</?script>".r

    def getPage(url : String) = Source.fromURL(url, "ISO-8859-1").mkString
    def getAPageImagesCount (url : String) = imgRegex.findAllIn(getPage(url)).matchData.toList.size
    def getAPageScriptCount (url : String) = scriptRegex.findAllIn(getPage(url)).matchData.toList.size
    def getAllInnerLinks (url : String) = linkRegex.findAllIn(getPage(url)).matchData.toList.map(_.group(1))
   
   def getStatSerially(mainUrl:String) ={
        
        val links:List[String] = getAllInnerLinks(mainUrl) ++ List(mainUrl)
        
        val moreThan2ImagesPageCount = links.count(link => getAPageImagesCount(link) > 2)

        val totalimagesCount = links.map(link => getAPageImagesCount(link)).reduce(_+_)
        
        println("moreThan2ImagesPageCount = " + moreThan2ImagesPageCount)
        println("totalimagesCount = " + totalimagesCount)
    }

    def getStatConcurrently(mainUrl:String) ={
        val links = (getAllInnerLinks(mainUrl) ++ List(mainUrl)).par

        val totalimagesCount = links.map(link => getAPageImagesCount(link)).reduce(_+_)
        
        println("totalimagesCount = " + totalimagesCount)
   
    }

    def main(args: Array[String])
    {

    //task2a
    println("image count on main page "+ mainUrl + "= " +getAPageImagesCount(mainUrl))
    println("script count on main page "+ mainUrl + "= " +getAPageScriptCount(mainUrl))

    //task2b, 2c
    val t1 = System.currentTimeMillis()
    println("Serial style") 
    println(getStatSerially(mainUrl))   
    val t2 = System.currentTimeMillis()

    //task2d
    val t3 = System.currentTimeMillis()
    println("Parallel style")
    println(getStatConcurrently(mainUrl))
    val t4 = System.currentTimeMillis()

    println("serial exec time = " + (t2 - t1))
    println("par exec time = " + (t4 - t3))
   }
}
