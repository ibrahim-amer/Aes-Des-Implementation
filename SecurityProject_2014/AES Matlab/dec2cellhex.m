function [ out ] = dec2cellhex( dec )

[W H] = size(dec);
for i = 1 : W
    for j = 1 : H
        out{i, j} = dec2hex(dec(i, j));
    end
end


end

