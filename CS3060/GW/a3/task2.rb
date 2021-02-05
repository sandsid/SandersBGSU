def  foo (a1)  # a1 is an array of strings
    b = a1.select{|x| x[ 0 ] != "c"} # strings in a1 which do not start with character “c” go to b
    p  b
  totalLength = a1.inject( 0 ){|s, item|  s + item.size  }
 p totalLength
end

foo(["aadfg", "cdf", "kjhg", "ce"])