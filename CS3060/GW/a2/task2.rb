def genRandomMatrix(n, x)
    a = [ ]
    (1..n).each do
            b = [ ]
            (1..x).each do
                    i = rand(10 .. 20) # you may need to fill in a parameter in rand( ) here
                    b.push(i)
            end
            a.push(b)
    end
    a
end

def printMatrix (m)
    m.each{|line| p line}
        
end




matrix = genRandomMatrix(10, 15)

printMatrix(matrix)

