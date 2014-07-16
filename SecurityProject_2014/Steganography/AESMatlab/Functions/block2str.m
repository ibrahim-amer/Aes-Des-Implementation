function [ str ] = block2str( block )
% This function converts from block (cipher or plain text) into 
% String 
% Input : block - Input block to be converted
% Output : The coressponding string to the specified block
str = '';
for i = 1 : 4
    for j = 1 : 4
        str = horzcat(str, char(block(i, j)));
    end
end


end

