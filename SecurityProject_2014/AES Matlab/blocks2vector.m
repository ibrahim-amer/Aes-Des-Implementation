function [ out ] = blocks2vector( blocks )

out = reshape(blocks{1}.',1,[]);
for i = 2 : length(blocks)
    reshapedmat = reshape(blocks{i}.',1,[]);
    out = horzcat(out, reshapedmat);
end
end

