function [ plaintext ] = AESDecrypt( ciphertext, cipherkey,sbox,sboxinv, rcon, mixcolmatinv)
keys = KeyExpansion(cipherkey, sbox, rcon);
[blocks blockshex] = getstates(ciphertext);
%for each block



%blocks = vector2blocks(ciphervector, 4, 4);
for j = 1 : length(blocks)
    block = blocks{j};
    block = colwisexor(block, keys{11});
    for i = 2 : length(keys) - 1
        blockshifted = shiftrows(block,'inv');
        x=dec2cellhex(blockshifted);
        blocksubbytes = SubBytes(blockshifted, sboxinv);
        x=dec2cellhex(blocksubbytes);
        block = colwisexor(blocksubbytes, keys{12-i});
        x=dec2cellhex(block);
        blockmix = MixCol(block, mixcolmatinv);
        x=dec2cellhex(blockmix);
        block=blockmix;
    end
    blockshifted = shiftrows(blockmix,'inv');
    blocksubbytes = SubBytes(blockshifted, sboxinv);
    block = colwisexor(blocksubbytes, keys{1});
    PTblocks{j} = block;
end

plaintext = '';
for i = 1 : length(PTblocks)
    plaintext = horzcat(plaintext, block2str(PTblocks{i}));
end

end