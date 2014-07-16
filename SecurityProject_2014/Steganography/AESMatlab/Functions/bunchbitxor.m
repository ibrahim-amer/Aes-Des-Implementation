function [ out ] = bunchbitxor( varargin )
% Takes a bunch of iput paramters and calculate bitxor between them
%  
if (nargin == 1)
    out = varargin{1}(1, 1);
    for i = 2 : length(varargin{1})
        out = bitxor(out, varargin{1}(1, i));
    end
else
    out = varargin{1};
    for i = 2 : length(varargin)
        out = bitxor(out, varargin{i});
    end
end

end

