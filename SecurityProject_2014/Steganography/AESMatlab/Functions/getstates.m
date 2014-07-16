function [ statesdec, stateshex ] = getstates( plaintext)

bytes = uint8(plaintext);
pthex = dec2hex(bytes);

ptsize = length(pthex) .* 8;
numofblocks = floor(ptsize / 128);
if (mod(ptsize, 128) ~= 0)
    numofblocks = numofblocks + 1;
end
%create cell array of the hexadecimal reprsentation of 
%the plain text
ptsize = length(pthex);
count = 1;
for k = 1 : numofblocks
    for i = 1 : 4
        for j = 1 : 4
            if (count > ptsize)
                stateshex{k}{i, j} = '00';
            else
                stateshex{k}{i, j} = pthex(count, :);
                count = count + 1;
            end
        end
    end 
end

for i = 1 : length(stateshex)
    statesdec{i} = cell2decmat(stateshex{i});
end
end

