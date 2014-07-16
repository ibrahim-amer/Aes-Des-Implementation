function [ out ] = SubBytes( InMat , Sbox)
%UNTITLED4 Summary of this function goes here
%   Detailed explanation goes here

[H W]=size(InMat);

for i = 1:H
    for j = 1:W
        x = InMat(i,j);
        x = dec2bin(x,8);
        l = x(1, 1 : 4);
        r = x(1, 5 : 8);
        ld = bin2dec(l); % row
        rd = bin2dec(r); % column
        out (i, j) = Sbox(ld+1,rd+1);
    end
end


end

