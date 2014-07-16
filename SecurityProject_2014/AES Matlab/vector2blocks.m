function [ blocks ] = vector2blocks( vector, n, m )

numofblocks = length(vector) ./ (n * m);
count = 1;
for i = 1 : numofblocks
    for j = 1 : n
        for k = 1 : m
            blocks{i}(j, k) = vector(1, count);
            count = count + 1;
        end
    end
end

end

