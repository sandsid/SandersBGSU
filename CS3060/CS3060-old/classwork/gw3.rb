

=begin
a = {"12" => "adam smith", "13"=> "sd roy", "22"=>"ed nelson"}
b1 = a.sort_by {|x| x[1].length}.to_h
p b1
b2 = a.sort{|x, y| x[1] <=> y[1]}
p b2


=end

def foo (a1)
    b = a1.select{|x| x[1] !="c"}
    p b
    totalLength = a1.inject(0){|s, item| s+item.length}
    p totalLength
end

foo(["aadfg", "cdf", "kjhg", "ce"])


