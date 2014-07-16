function [ out ] = shiftrows( mat, state )
[W H] = size(mat);
out(1, :) = mat(1, :);
if (nargin < 2)
    for i = 2 : W
        out(i, :) = circularshift(mat(i, :), i - 1);
    end

else
    for i = 2 : W
        out(i, :) = circularshift(mat(i, :), i - 1, state);
    end
end
end

