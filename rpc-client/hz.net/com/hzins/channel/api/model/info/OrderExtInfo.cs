/**
 * Copyright (c) 2006-2015 Hzins Ltd. All Rights Reserved. 
 *  
 * This code is the confidential and proprietary information of   
 * Hzins. You shall not disclose such Confidential Information   
 * and shall use it only in accordance with the terms of the agreements   
 * you entered into with Hzins,http://www.hzins.com.
 *  
 */   
namespace com.hzins.channel.api.model.info; 

using System.Collections.Generic;
using java.util.Map;

/**
 * <p>
 * 
 * </p>
 * @author	hz15031081 
 * @date	2015-4-13 下午4:36:22
 * @version      
 */
public class OrderExtInfo {
    
    // 惠择投保单号
    private String insureNum;
    
    // 被保人id集合
    private IList<String> insurantIds;
    
    // 被保人数量
    private int insurantCount;
    
    //本单总价
    private double priceTotal;

    private virtual Dictionary<String, String> insurantMap;
    
    
    
    
    
    
    public virtual Dictionary<String, String> getInsurantMap() {
        return insurantMap;
    }



    
    public virtual void setInsurantMap(Dictionary<String, String> insurantMap) {
        this.insurantMap = insurantMap;
    }



    public virtual double getPriceTotal() {
        return priceTotal;
    }


    
    public virtual void setPriceTotal(double priceTotal) {
        this.priceTotal = priceTotal;
    }


    public virtual String getInsureNum() {
        return insureNum;
    }

    
    public virtual void setInsureNum(String insureNum) {
        this.insureNum = insureNum;
    }

    
    public virtual IList<String> getInsurantIds() {
        return insurantIds;
    }

    
    public virtual void setInsurantIds(IList<String> insurantIds) {
        this.insurantIds = insurantIds;
    }

    
    public virtual int getInsurantCount() {
        return insurantCount;
    }

    
    public virtual void setInsurantCount(int insurantCount) {
        this.insurantCount = insurantCount;
    }

   
    
    
}
 