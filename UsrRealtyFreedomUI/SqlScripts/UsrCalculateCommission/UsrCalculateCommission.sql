update UsrRealtyFreedomUI
set UsrCommision =
	case 
		 when UsrOfferTypeId = '1CFF7F0C-C117-4869-AB58-23BBB9503ECC' then UsrPrice * 0.02 --rental
		 when UsrOfferTypeId = 'F5AF8D54-D908-4E67-955E-50770F902E6C' then UsrPrice * 0.50 --sale
 	end
where UsrCommision = 0;