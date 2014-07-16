function [ stegomsg ] = AESEncrypt( plaintext, cipherkey, sbox, rcon, mixcolmat)
keys = KeyExpansion(cipherkey, sbox, rcon);
[blocks blockshex] = getstates(plaintext);
%for each block

%blocks{1} = plaintext;
for j = 1 : length(blocks)
    block = blocks{j};
    block = colwisexor(block, keys{1});
    for i = 2 : length(keys) - 1
        blocksubbytes = SubBytes(block, sbox);
        blockshifted = shiftrows(blocksubbytes);
        blockmix = MixCol(blockshifted, mixcolmat);
        block = colwisexor(blockmix, keys{i});
    end
    blocksubbytes = SubBytes(block, sbox);
    blockshifted = shiftrows(blocksubbytes);
    block = colwisexor(blockshifted, keys{11});
    cipherblocks{j} = block;
end
%ciphervector = blocks2vector(cipherblocks);
stegomsg = '';
for i = 1 : length(cipherblocks)
    stegomsg = horzcat(stegomsg, block2str(cipherblocks{i}));
end



end