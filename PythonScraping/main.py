from xml.etree.ElementInclude import include
from selenium.webdriver.common.by import By
from selenium.webdriver.support import expected_conditions as EC
from selenium.webdriver.support.ui import WebDriverWait
from selenium import webdriver

websites = open("weby.txt", 'r').readlines()

driver = webdriver.Firefox()

driver.get(websites[0])

driver.find_element(By.CSS_SELECTOR , ".VtwTSb > form:nth-child(2) > div:nth-child(1) > div:nth-child(1) > button:nth-child(1)").click()

output = open("output.txt", "w")

webs = []

for web in websites:
    
    driver.get(web)

    
    try:
        WebDriverWait(driver, 20).until(EC.presence_of_element_located((By.CSS_SELECTOR, "div.RcCsl:nth-child(3) > button:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(1) > img:nth-child(1)")))
        w = driver.find_element(By.CSS_SELECTOR, ".ITvuef > div:nth-child(1)")
        print(w.text)
        if w.text not in webs:
            output.write(w.text + "\n")
            webs.append(w.text)

    except Exception as e: 
        print(e)
        
