function [ out ] = cell2decmat( cell )

[W H] = size(cell);
for i = 1 : W
    for j = 1 : H
        out(i, j) = hex2dec(cell{i, j});
    end
end


end

