// SKU = Stock Keeping Unit
string productCode = "01-MN-L";

string[] productDetails = productCode.Split('-');

string itemType = "";
string itemColor = "";
string itemSize = "";

// Determine the type of product based on the SKU code
switch (productDetails[0])
{
    case "01":
        itemType = "Sweatshirt";
        break;
    case "02":
        itemType = "T-Shirt";
        break;
    case "03":
        itemType = "Sweatpants";
        break;
    default:
        itemType = "Other";
        break;
}

// Determine the color of the product based on the SKU code
switch (productDetails[1])
{
    case "BL":
        itemColor = "Black";
        break;
    case "MN":
        itemColor = "Maroon";
        break;
    default:
        itemColor = "White";
        break;
}

// Determine the size of the product based on the SKU code
switch (productDetails[2])
{
    case "S":
        itemSize = "Small";
        break;
    case "M":
        itemSize = "Medium";
        break;
    case "L":
        itemSize = "Large";
        break;
    default:
        itemSize = "One Size Fits All";
        break;
}

//Product: Large Maroon Sweatshirt
Console.WriteLine($"Product: {itemSize} {itemColor} {itemType}"); 
