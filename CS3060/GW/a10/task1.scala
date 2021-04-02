import scala.io._
object PageLoader {
     def getPageSize(url : String)={
         val page = Source.fromURL(url)("ISO-8859-1").mkString
         val linkRegex = "(?i)<a.+?href=\"(http.+?)\".*?>(.+?)</a>".r
         linkRegex.findAllIn(page).matchData.toList.size
     } 

}
object GroupWorkTen {
    def main(args: Array[String]): Unit = 
    {
        val urls = List("https://www.bbc.com/", "https://www.cnn.com/", "https://box.com", "https://dropbox.com" )
        def getPageSize() = {   
            urls map { url =>              
                println("Num of URL's for " + url + ": \t" + PageLoader.getPageSize(url))  
            }
        }
        val t1 = System.currentTimeMillis()
        getPageSize
        val t2 = System.currentTimeMillis()
        def getPageSizeConcurrently() = {   
            urls.par map { url =>              
                println("Num of URL's for " + url + ": \t" + PageLoader.getPageSize(url))  
            }
        }
        val t3 = System.currentTimeMillis()
        getPageSizeConcurrently
        val t4 = System.currentTimeMillis()
        println("serial exec time = \t" + (t2 - t1))
        println("par exec time = \t" + (t4 - t3))

    }
}

