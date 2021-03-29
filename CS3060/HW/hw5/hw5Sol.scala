import java.io.{File, PrintWriter}

import scala.io.Source
import scala.io.StdIn.readLine
import scala.util.matching.Regex



object Wordcount {

  def main(args: Array[String]) {
    // Task 1:

    val outfile = "mytext.txt"
    val writer = new PrintWriter(new File(outfile))
    println("Enter 3 lines of text to be saved to a file:")
    var line = ""
    for (i <- 0 until 3) {
      line = readLine()
      writer.write(line + "\n")
    }
    writer.close()

    // Task 2:
    var coolFactor = -1

    println("Enter a filename (without the extension): ")
    val theFile = readLine()

    val fileHandler = Source.fromFile(theFile + ".txt")
    val lineIterator = fileHandler.getLines

    for (line <- lineIterator) {
      var lineInfo = line.split("\\s+")

      for (a <- 0 to (lineInfo.length - 1)) {
        if (lineInfo(a).toString == "Scala" || lineInfo(a).toString == "scala") {
          coolFactor = 1
        } else if (lineInfo(a).toString == "Prolog" || lineInfo(a).toString == "prolog") {
          coolFactor = 0
        }
      }

    }

    if (coolFactor == 1) {
      println("The file content is interesting")
    } else if (coolFactor == 0) {
      println("The file content is not interesting")
    } else {
      println("The file is meaningless")
    }

    //Task 3:
    for (a <- 5 to 24) {
      println("The cube of " + a + " is " + (a * a * a))
    }

    // Task 4:


    val content = Source.fromFile("C:/Users/pprab/OneDrive/Desktop/story.txt").getLines.mkString(" ")
    val words = content.split(" ")
    var wordMap = new scala.collection.mutable.HashMap[String, Int]
    var totalWords = 0
    var totalUnique = 0
    var word = ""
    for (rawWord <- words) {
      // Remove all punctuation
      word = rawWord.replaceAll("""[\p{Punct}]""", "")

      if (wordMap.isDefinedAt(word) == false) {
        wordMap += word -> 0
        totalUnique += 1
      }
      wordMap(word) += 1
      totalWords += 1
    }

    var first = words(0)
    var second = words(0)
    var third = words(0)
    val keys = wordMap.keysIterator
    for (word <- keys) {
      if (wordMap(word) > wordMap(first)) {
        third = second
        second = first
        first = word
      }
      if (wordMap(word) > wordMap(first)) {
        third = second
        second = word
      }
      if (wordMap(word) > wordMap(first)) {
        third = word
      }
    }

    println("There are " + totalWords + " total words in the story.")
    println("There are " + totalUnique + " unique words in the story.")
    println("The third most frequent word in the story is \"" + third + "\".")
  }}