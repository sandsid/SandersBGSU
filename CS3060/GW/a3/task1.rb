a = {"12" => "adam smith", "13" => "sd roy", "22" => "ed nelson"}
b1 = a.sort_by{|x| x[1].size }.to_h # sort h according to the length of employee names
p   b1
b2 = a.sort{|x, y| x[ 1 ] <=>y[ 1 ]} # sort h according to the employee names
p   b2
