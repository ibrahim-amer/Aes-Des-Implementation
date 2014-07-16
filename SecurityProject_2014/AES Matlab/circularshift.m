function [ out ] = circularshift( col, k, state )

f = col;
if (nargin < 3 || ~strcmp(state, 'inv'))
  f = fliplr(col);
  cs = circshift(f', [k 0]);
  cs = cs';
  out = fliplr(cs);
else
cs = circshift(f', [k 0]);
cs = cs';
%out = fliplr(cs);
out = cs;
end
end

