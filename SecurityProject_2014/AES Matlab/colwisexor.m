function [ out ] = colwisexor( a, b )

for i = 1 : length(a)
    e1 = a(i, :);
    e2 = b(i, :);
    res = bitxor(e1, e2);
    out(i, :) = res;
end


end

