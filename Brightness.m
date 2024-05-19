function RGB = Brightness(image, bFactor)
    RGB = uint8(image+bFactor*10);
end